using JetBrains.Annotations;
using MLTD;
using MLTD.Assets;
using System.Diagnostics;

namespace MLTDABD.Forms
{
    public partial class FormDiff : Form
    {
        [NotNull, ItemNotNull]
        private readonly HashSet<ListViewItem> _downloadPendingSet;
        [CanBeNull]
        private DownloadConfig _downloadConfig;

        public FormDiff([NotNull, ItemNotNull] FormAsset[] manifestForms)
        {
            _manifestForms = manifestForms;
            _downloadPendingSet = new HashSet<ListViewItem>();

            InitializeComponent();
            RegisterEventHandlers();
        }

        ~FormDiff()
        {
            UnregisterEventHandlers();
        }

        private void RegisterEventHandlers()
        {
            Load += FDiff_Load!;
            Resize += FDiff_Resize!;
            btnDiff.Click += BtnDiff_Click!;
            btnSaveDiff.Click += BtnSaveDiff_Click!;
        }

        private void UnregisterEventHandlers()
        {
            Load -= FDiff_Load!;
            Resize -= FDiff_Resize!;
            btnDiff.Click -= BtnDiff_Click!;
            btnSaveDiff.Click -= BtnSaveDiff_Click!;
        }

        private void FDiff_Load(object sender, EventArgs e)
        {
            foreach (var form in _manifestForms)
            {
                comboBox1.Items.Add(form.Text);
                comboBox2.Items.Add(form.Text);
            }

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;

            {
                {
                    var panelClientSize = panel2.ClientSize;

                    var loc = btnDiff.Location;
                    var buttonSize = btnDiff.Size;

                    Debug.Assert(buttonSize == btnSaveDiff.Size);

                    const int halfMargin = 4;

                    var center = new Point(panelClientSize.Width / 2, loc.Y);

                    btnDiff.Location = new Point(center.X - btnDiff.Width - halfMargin, center.Y);
                    btnSaveDiff.Location = new Point(center.X + halfMargin, center.Y);
                }

                {
                    var formClientSize = ClientSize;

                    var loc = panel2.Location;
                    var panelSize = panel2.Size;

                    panel2.Location = new Point((formClientSize.Width - panelSize.Width) / 2, loc.Y);
                }
            }
        }

        private void FDiff_Resize(object sender, EventArgs e)
        {
            var formClientSize = ClientSize;

            {
                var loc = panel2.Location;
                var panelSize = panel2.Size;

                panel2.Location = new Point((formClientSize.Width - panelSize.Width) / 2, loc.Y);
            }
        }

        private void BtnDiff_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == comboBox2.SelectedIndex || string.Equals(comboBox1.Text, comboBox2.Text, StringComparison.Ordinal))
            {
                MessageBox.Show("Please select two different files to diff.", ApplicationHelper.GetApplicationTitle(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var waitform = new FormProgress(1);
            _ = Task.Run(() => waitform.ShowDialog());

            _diffSources = (comboBox1.Text, comboBox2.Text);

            LoadManifestToListView(comboBox1.SelectedIndex, lv1);
            LoadManifestToListView(comboBox2.SelectedIndex, lv2);

            Diff(comboBox1.SelectedIndex, comboBox2.SelectedIndex);

            btnSaveDiff.Enabled = true;
        }

        private void BtnSaveDiff_Click(object sender, EventArgs e)
        {
            if (_diffs == null)
            {
                MessageBox.Show("You have to diff at least once to save the diff.", ApplicationHelper.GetApplicationTitle(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            sfd.AddExtension = true;
            sfd.AutoUpgradeEnabled = true;
            sfd.DereferenceLinks = true;
            sfd.Filter = "Text Files (*.txt)|*.txt|All Files (*)|*";
            sfd.OverwritePrompt = true;
            sfd.SupportMultiDottedExtensions = true;
            sfd.ValidateNames = true;

            var r = sfd.ShowDialog(this);

            if (r == DialogResult.Cancel)
            {
                return;
            }

            using (var fileStream = File.Open(sfd.FileName, FileMode.Create, FileAccess.Write, FileShare.Write))
            {
                using (var streamWriter = new StreamWriter(fileStream, MltdConstants.Utf8WithoutBom))
                {
                    streamWriter.WriteLine("# Manifest diff created by MLTD Manifest Tools");
                    streamWriter.WriteLine("# Source 1 (base): {0}", _diffSources.File1);
                    streamWriter.WriteLine("# Source 2 (changed): {0}", _diffSources.File2);
                    streamWriter.WriteLine("# Columns: [state] [resource name] [remote name] [content hash] [size in bytes]");
                    streamWriter.WriteLine();

                    foreach (var (info, state) in _diffs)
                    {
                        switch (state)
                        {
                            case DiffState.Same:
                                streamWriter.Write('=');
                                break;
                            case DiffState.Added:
                                streamWriter.Write('+');
                                break;
                            case DiffState.Removed:
                                streamWriter.Write('-');
                                break;
                            default:
                                throw new ArgumentOutOfRangeException(nameof(state), state, null);
                        }

                        streamWriter.Write('\t');

                        streamWriter.Write(info.ResourceName);
                        streamWriter.Write('\t');
                        streamWriter.Write(info.RemoteName);
                        streamWriter.Write('\t');
                        streamWriter.Write(info.ContentHash);
                        streamWriter.Write('\t');
                        streamWriter.WriteLine(info.Size.ToString());
                    }

                    streamWriter.WriteLine();
                    streamWriter.WriteLine("# End of diff");
                }
            }

            MessageBox.Show($"Diff saved to '{sfd.FileName}'.", ApplicationHelper.GetApplicationTitle(), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadManifestToListView(int index, [NotNull] ListView lv)
        {
            var manifest = _manifestForms[index].Manifest;

            var assetList = new List<AssetInfo>(manifest.Assets);

            assetList.Sort(CompareAssetInfo);

            lv.BeginUpdate();

            lv.Items.Clear();

            var listViewItems = new List<ListViewItem>();

            foreach (var assetInfo in assetList)
            {
                var lvi = new ListViewItem(assetInfo.ResourceName);
                lvi.SubItems.Add(assetInfo.RemoteName);
                lvi.SubItems.Add(assetInfo.ContentHash);
                lvi.SubItems.Add(assetInfo.Size.ToString());
                listViewItems.Add(lvi);
            }

            lv.Items.AddRange(listViewItems.ToArray());

            lv.EndUpdate();
        }

        private void Diff(int index1, int index2)
        {
            var man1 = _manifestForms[index1].Manifest;
            var man2 = _manifestForms[index2].Manifest;

            var added = new HashSet<AssetInfo>(man2.Assets, SimpleAssetInfoComparer.Instance);
            added.ExceptWith(man1.Assets);

            var removed = new HashSet<AssetInfo>(man1.Assets, SimpleAssetInfoComparer.Instance);
            removed.ExceptWith(man2.Assets);

            var fullDiff = new List<(AssetInfo Info, DiffState State)>();

            foreach (var item in added)
            {
                fullDiff.Add((item, DiffState.Added));
            }

            foreach (var item in removed)
            {
                fullDiff.Add((item, DiffState.Removed));
            }

            fullDiff.Sort(CompareInfoAndStateTuple);
            _diffs = fullDiff.ToArray();

            lvDiff.BeginUpdate();

            lvDiff.Items.Clear();

            var listViewItems = new List<ListViewItem>();

            foreach (var (assetInfo, state) in fullDiff)
            {
                var lvi = new ListViewItem();
                lvi.SubItems.Add(assetInfo.ResourceName);
                lvi.SubItems.Add(assetInfo.RemoteName);
                lvi.SubItems.Add(assetInfo.ContentHash);
                lvi.SubItems.Add(assetInfo.Size.ToString());

                switch (state)
                {
                    case DiffState.Added:
                        lvi.BackColor = Color.PaleGreen;
                        lvi.Text = "+";
                        break;
                    case DiffState.Removed:
                        lvi.BackColor = Color.LightPink;
                        lvi.Text = "-";
                        break;
                    case DiffState.Same:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(state), state, null);
                }

                listViewItems.Add(lvi);
            }

            lvDiff.Items.AddRange(listViewItems.ToArray());

            lvDiff.EndUpdate();
        }

        private static int CompareAssetInfo([NotNull] AssetInfo a, [NotNull] AssetInfo b)
        {
            return string.CompareOrdinal(a.ResourceName, b.ResourceName);
        }

        private static int CompareInfoAndStateTuple((AssetInfo Info, DiffState State) a, (AssetInfo Info, DiffState State) b)
        {
            var c = CompareAssetInfo(a.Info, b.Info);

            if (c != 0)
            {
                return c;
            }

            return (int)a.State - (int)b.State;
        }

        [NotNull, ItemNotNull]
        private readonly FormAsset[] _manifestForms;

        [CanBeNull]
        private (AssetInfo Info, DiffState State)[] _diffs;

        private (string File1, string File2) _diffSources;

        private enum DiffState
        {

            Same = 0,

            Added = 1,

            Removed = -1,

        }

        private sealed class SimpleAssetInfoComparer : IEqualityComparer<AssetInfo>
        {

            private SimpleAssetInfoComparer()
            {
            }

            public bool Equals(AssetInfo? x, AssetInfo? y)
            {
                if (ReferenceEquals(x, null))
                {
                    if (ReferenceEquals(y, null))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    if (ReferenceEquals(y, null))
                    {
                        return false;
                    }
                    else
                    {
                        return string.Equals(x.ResourceName, y.ResourceName, StringComparison.Ordinal) &&
                               string.Equals(x.ContentHash, y.ContentHash, StringComparison.Ordinal);
                    }
                }
            }

            public int GetHashCode(AssetInfo obj)
            {
                if (obj is null)
                {
                    return 0;
                }
                else
                {
                    const int seed = 17;
                    const int mul = 31;

                    var hash = seed;
                    hash += obj.ResourceName.GetHashCode() * mul;
                    hash += obj.ContentHash.GetHashCode() * mul;

                    return hash;
                }
            }

            [NotNull]
            public static readonly SimpleAssetInfoComparer Instance = new();

        }

        private void ctxAPD_Click(object sender, EventArgs e)
        {
            AddSelectedItemsToPendingDownloads();
        }

        private void ctxRemove_Click(object sender, EventArgs e)
        {
            var itemCollection = lvDownload.SelectedItems;
            var itemCount = itemCollection.Count;

            if (itemCount == 0)
            {
                return;
            }

            if (itemCount == 1)
            {
                var item = itemCollection[0];
                var tag = item.Tag as ListViewItem;
                Debug.Assert(tag != null);
                _downloadPendingSet.Remove(tag);
                lvDownload.Items.RemoveAt(item.Index);

                return;
            }

            var itemArray = new ListViewItem[itemCount];

            for (var i = 0; i < itemCount; i += 1)
            {
                itemArray[i] = itemCollection[i];
            }

            foreach (var item in itemArray)
            {
                var tag = item.Tag as ListViewItem;
                Debug.Assert(tag != null);
                _downloadPendingSet.Remove(tag);
                lvDownload.Items.Remove(item);
            }
        }

        private void ctxClear_Click(object sender, EventArgs e)
        {
            ClearPendingDownloads();
        }

        private void lvDiff_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && lvDiff.SelectedItems.Count > 0)
            {
                AddSelectedItemsToPendingDownloads();
            }
        }

        private void lvDiff_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && lvDiff.SelectedItems.Count > 0)
            {
                ctxL.Show(lvDiff, e.Location);
            }
        }

        private void AddSelectedItemsToPendingDownloads()
        {
            var items = lvDiff.SelectedItems;
            var set = _downloadPendingSet;
            var lv = lvDownload;

            List<AssetInfo> assetInfos = new List<AssetInfo>(DifftoAssetInfo(items));
            AssetInfoList assetInfoList = new(assetInfos);
            

            lv.BeginUpdate();

            foreach (ListViewItem item in items)
            {
                AssetInfo assetInfo = new(item.SubItems[1].Text, item.SubItems[3].Text, item.SubItems[2].Text, uint.Parse(item.SubItems[4].Text));
                TreeListItem treeListItem = new(assetInfo);
                if (set.Contains(item))
                {
                    continue;
                }
                

                set.Add(item);

                var lvi = new ListViewItem(treeListItem.LocalName);
                lvi.SubItems.Add(MathUtilities.GetHumanReadableFileSize(treeListItem.Size));
                lvi.Tag = treeListItem;

                lv.Items.Add(lvi);
            }

            lv.EndUpdate();
        }

        private List<AssetInfo> DifftoAssetInfo(ListView.SelectedListViewItemCollection items)
        {
            List<AssetInfo> result = new List<AssetInfo>();
            foreach (ListViewItem item in items)
            {
                AssetInfo assetInfo = new(item.SubItems[1].Text,item.SubItems[3].Text,item.SubItems[2].Text,uint.Parse(item.SubItems[4].Text));
                result.Add(assetInfo);
            }
            return result;
        }

        private void ClearPendingDownloads()
        {
            lvDownload.Items.Clear();
            _downloadPendingSet.Clear();
        }

        private void lvDownload_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
            {
                return;
            }

            ctxRemove.Enabled = lvDownload.SelectedItems.Count > 0;
            ctxDL.Enabled = lvDownload.SelectedItems.Count > 0;

            ctxR.Show(lvDownload, e.Location);
        }

        private void ctxDL_Click(object sender, EventArgs e)
        {
            var listItems = lvDownload.Items;

            if (listItems.Count == 0)
            {
                return;
            }

            _downloadConfig = _manifestForms[comboBox2.SelectedIndex]._downloadConfig;

            if (_downloadConfig == null)
            {
                const string message = "You are trying to download assets according to a local manifest. You can only perform this when you know the exact details of the manifest (resource version, engine version, platform info, etc.) otherwise it always fails.\nAgain, only proceed if you understand exactly what you are doing. Do you want to continue?";
                var r = MessageBox.Show(message, ApplicationHelper.GetApplicationTitle(), MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (r == DialogResult.No)
                {
                    return;
                }
                else
                {
                    MessageBox.Show("Download has been suspended.", ApplicationHelper.GetApplicationTitle(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                var items = new TreeListItem[listItems.Count];

                for (var i = 0; i < items.Length; i += 1)
                {
                    items[i] = listItems[i].Tag as TreeListItem;
                }

                using var f = new FormDownload(items, _downloadConfig);
                f.ShowDialog(this);
            }
        }

        private void lvDiff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDiff.SelectedItems.Count > 0)
            {
                int idx = 0;
                idx = lvDiff.SelectedItems[0].Index;
                //assetTreeList1.Selecte.;
            }
        }
    }
}

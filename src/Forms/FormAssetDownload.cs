using JetBrains.Annotations;
using MLTD;
using MLTDABD.APIs;
using MLTDABD.APIs.Matsurihi;
using MLTDABD.APIs.Matsurihi.MeCommon;

namespace MLTDABD.Forms
{
    public partial class FormAssetDownload : Form
    {
        private FormAssetDownload()
        {
            InitializeComponent();
        }

        private void FManifestDownload_Load(object sender, EventArgs e)
        {
            cboHost.SelectedIndex = 0;
        }

        private void RadResLatest_Click(object sender, EventArgs e)
        {
            cboResVersion.Enabled = false;
        }

        private async void RadResManual_Click(object sender, EventArgs e)
        {
            cboResVersion.Enabled = true;

            if (cboResVersion.Items.Count > 0)
            {
                return;
            }

            Enabled = false;

            try
            {
                var resVersions = await Me.GetAssetVersions();

                foreach (var resVersion in resVersions)
                {
                    cboResVersion.Items.Add(resVersion.Version.ToString());
                }

                if (cboResVersion.Items.Count > 0)
                {
                    cboResVersion.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), ApplicationHelper.GetApplicationTitle(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                radResManual.Enabled = false;
                radResLatest.PerformClick();
            }
            finally
            {
                Enabled = true;
            }
        }

        private async void BtnOK_Click(object sender, EventArgs e)
        {
            Enabled = false;

            DownloadConfig config;

            try
            {
                var (b, message) = ValidateFields();

                if (!b)
                {
                    MessageBox.Show(message, ApplicationHelper.GetApplicationTitle(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    config = await GetConfig();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), ApplicationHelper.GetApplicationTitle(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            finally
            {
                Enabled = true;
            }

            Config = config;
            DialogResult = DialogResult.OK;
        }

        public static (DialogResult, DownloadConfig) ShowModal([CanBeNull] IWin32Window window)
        {
            DialogResult r;
            DownloadConfig config;

            using (var f = new FormAssetDownload())
            {
                r = f.ShowDialog(window);
                config = f.Config!;
            }

            return (r, config);
        }

        [CanBeNull]
        private DownloadConfig? Config { get; set; }

        private (bool, string) ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(cboHost.Text))
            {
                return (false, "Host cannot be empty.");
            }

            if (string.IsNullOrWhiteSpace(txtAssetVersion.Text))
            {
                return (false, "Unity asset version cannot be empty.");
            }

            if (radResManual.Checked)
            {
                if (!int.TryParse(cboResVersion.Text, out var n) || n <= 0)
                {
                    return (false, "Please specify a valid resource version.");
                }
            }

            return (true, null!);
        }

        [NotNull]
        private async Task<DownloadConfig> GetConfig()
        {
            int resourceVersion;
            string resourceAssetName;

            if (radResLatest.Checked)
            {
                var latest = await Me.GetLatestVersion();
                if (latest != null)
                {
                    resourceVersion = (int)latest.Res!.Version!;
                    resourceAssetName = latest.Res.IndexName!;
                }
                else
                {
                    resourceVersion = -1;
                    resourceAssetName = "";
                }
            }
            else
            {
                resourceVersion = int.Parse(cboResVersion.Text);
                RVersion res;

                try
                {
                    res = await Me.GetAssetVersion(resourceVersion);
                }
                catch (HttpRequestException ex)
                {
                    throw new ApplicationException($"Cannot get manifest of resource version {resourceVersion}. Maybe this version does not exist.", ex);
                }

                resourceAssetName = res.IndexName!;
            }

            var platform = radPlatformAndroid.Checked ? UMPF.Android : UMPF.iOS;

            return new DownloadConfig(cboHost.Text, txtAssetVersion.Text, resourceVersion, radResLatest.Checked, platform, resourceAssetName);
        }

    }
}

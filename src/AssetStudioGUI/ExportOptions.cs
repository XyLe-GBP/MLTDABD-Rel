using MLTDABD_Rel.Properties;

namespace AssetStudioGUI
{
    public partial class ExportOptions : Form
    {
        public ExportOptions()
        {
            InitializeComponent();
            assetGroupOptions.SelectedIndex = Settings.Default.assetGroupOption;
            restoreExtensionName.Checked = Settings.Default.restoreExtensionName;
            converttexture.Checked = Settings.Default.convertTexture;
            convertAudio.Checked = Settings.Default.convertAudio;
            var str = Settings.Default.convertType;
            foreach (Control c in panel1.Controls)
            {
                if (c.Text == str)
                {
                    ((RadioButton)c).Checked = true;
                    break;
                }
            }
            openAfterExport.Checked = Settings.Default.openAfterExport;
            eulerFilter.Checked = Settings.Default.eulerFilter;
            filterPrecision.Value = Settings.Default.filterPrecision;
            exportAllNodes.Checked = Settings.Default.exportAllNodes;
            exportSkins.Checked = Settings.Default.exportSkins;
            exportAnimations.Checked = Settings.Default.exportAnimations;
            exportBlendShape.Checked = Settings.Default.exportBlendShape;
            castToBone.Checked = Settings.Default.castToBone;
            boneSize.Value = Settings.Default.boneSize;
            scaleFactor.Value = Settings.Default.scaleFactor;
            fbxVersion.SelectedIndex = Settings.Default.fbxVersion;
            fbxFormat.SelectedIndex = Settings.Default.fbxFormat;
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            Settings.Default.assetGroupOption = assetGroupOptions.SelectedIndex;
            Settings.Default.restoreExtensionName = restoreExtensionName.Checked;
            Settings.Default.convertTexture = converttexture.Checked;
            Settings.Default.convertAudio = convertAudio.Checked;
            foreach (Control c in panel1.Controls)
            {
                if (((RadioButton)c).Checked)
                {
                    Settings.Default.convertType = c.Text;
                    break;
                }
            }
            Settings.Default.openAfterExport = openAfterExport.Checked;
            Settings.Default.eulerFilter = eulerFilter.Checked;
            Settings.Default.filterPrecision = filterPrecision.Value;
            Settings.Default.exportAllNodes = exportAllNodes.Checked;
            Settings.Default.exportSkins = exportSkins.Checked;
            Settings.Default.exportAnimations = exportAnimations.Checked;
            Settings.Default.exportBlendShape = exportBlendShape.Checked;
            Settings.Default.castToBone = castToBone.Checked;
            Settings.Default.boneSize = boneSize.Value;
            Settings.Default.scaleFactor = scaleFactor.Value;
            Settings.Default.fbxVersion = fbxVersion.SelectedIndex;
            Settings.Default.fbxFormat = fbxFormat.SelectedIndex;
            Settings.Default.Save();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

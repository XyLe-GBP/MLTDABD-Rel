using JetBrains.Annotations;
using System.Diagnostics;

namespace MLTDABD.Forms
{
    public partial class FormAbout : Form
    {

        public FormAbout()
        {
            InitializeComponent();
            RegisterEventHandlers();
        }

        ~FormAbout()
        {
            UnregisterEventHandlers();
        }

        private void RegisterEventHandlers()
        {
            linkLabel2.LinkClicked += LinkLabel2_LinkClicked;
            linkLabel3.LinkClicked += LinkLabel3_LinkClicked;
        }

        private void UnregisterEventHandlers()
        {
            linkLabel2.LinkClicked -= LinkLabel2_LinkClicked;
            linkLabel3.LinkClicked -= LinkLabel3_LinkClicked;
        }

        private void LinkLabel2_LinkClicked(object sender, EventArgs e)
        {
            OpenUrl("https://github.com/OpenMLTD/MLTDTools");
        }

        private void LinkLabel3_LinkClicked(object sender, EventArgs e)
        {
            OpenUrl("https://www.matsurihi.me");
        }

        private static void OpenUrl([NotNull] string url)
        {
            var psi = new ProcessStartInfo(url)
            {
                UseShellExecute = true
            };

            Process.Start(psi);
        }

    }
}

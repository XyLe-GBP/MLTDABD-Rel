using JetBrains.Annotations;

namespace MLTDABD.Forms
{
    public partial class FormProgress : Form
    {
        private readonly int flag = 0;
        private readonly string msg;
        public FormProgress([NotNull] int flag, string msg = "Please wait a moment...")
        {
            this.flag = flag;
            this.msg = msg;
            InitializeComponent();
        }

        private async void FormProgress_Load(object sender, EventArgs e)
        {
            label_info.Text = msg;
            progressBar1.Style = ProgressBarStyle.Marquee;
            progressBar1.MarqueeAnimationSpeed = 50;
            await Task.Run(() => Main());
        }

        private void Main()
        {
            switch (flag)
            {
                case 0:
                    {
                        Close();
                    }
                    break;
                case 1:
                    {
                        Loop();
                    }
                    break;
            }
            return;
        }

        private void Loop()
        {
            while (true)
            {

            }
        }
    }
}

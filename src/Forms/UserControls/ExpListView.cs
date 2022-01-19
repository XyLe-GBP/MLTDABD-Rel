using MLTDABD.Common;

namespace MLTDABD.Forms
{
    public class ExplorerListView : ListView
    {

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);

            if (!DesignMode && OSUtil.IsWindowsVistaOrLater())
            {
                _ = NativeMethods.SetWindowTheme(Handle, "explorer", null!);
            }
        }

    }
}

using JetBrains.Annotations;

namespace MLTDABD.Common
{
    internal static class TextBoxExtensions
    {

        public static void SetPlaceholderText([NotNull] this TextBox textBox, [CanBeNull] string placeholder)
        {
            if (placeholder == null)
            {
                placeholder = string.Empty;
            }

            NativeMethods.SendMessage(textBox.Handle, NativeMethods.EM_SETCUEBANNER, 0, placeholder);
        }

    }
}

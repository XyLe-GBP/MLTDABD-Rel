namespace MLTDABD
{
    // ReSharper disable once InconsistentNaming
    internal static class OSUtil
    {

        public static bool IsWindowsVistaOrLater()
        {
            var osVersion = Environment.OSVersion;

            return osVersion.Platform == PlatformID.Win32NT && osVersion.Version.Major >= 6;
        }

    }
}
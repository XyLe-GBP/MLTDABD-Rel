using JetBrains.Annotations;
using MLTDABD.APIs;

namespace MLTDABD.Common
{
    internal static class UMPFExtensions
    {

        [NotNull]
        public static string ToStringFast(this UMPF platform)
        {
            switch (platform)
            {
                case UMPF.Unknown:
                    return "Unknown";
                case UMPF.Android:
                    return "Android";
                case UMPF.iOS:
                    return "iOS";
                default:
                    throw new ArgumentOutOfRangeException(nameof(platform), platform, null);
            }
        }

    }
}

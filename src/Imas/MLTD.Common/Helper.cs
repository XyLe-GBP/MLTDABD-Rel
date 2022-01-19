using System.Reflection;
using System.Runtime.CompilerServices;

namespace MLTD
{
    public static class ApplicationHelper
    {
        // https://stackoverflow.com/questions/1348643/how-performant-is-stackframe/1348853#1348853
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static string GetCallerMethodName([CallerMemberName] string callerMemberName = null!)
        {
            return callerMemberName;
        }

        public static string GetApplicationTitle()
        {
            return ApplicationTitle.Value;
        }

        public static string GetApplicationVersionString()
        {
            return ApplicationVersion.Value;
        }

        private static readonly Lazy<Assembly> ApplicationAssembly = new(Assembly.GetEntryAssembly!);

        private static readonly Lazy<string> ApplicationTitle = new(() =>
        {
            var assembly = ApplicationAssembly.Value;
            var attr = assembly.GetCustomAttribute<AssemblyTitleAttribute>();

            return attr?.Title ?? string.Empty;
        });

        private static readonly Lazy<string> ApplicationVersion = new(() =>
        {
            var assembly = ApplicationAssembly.Value;

            var informationalVersionAttribute = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>();
            var version = informationalVersionAttribute?.InformationalVersion;

            if (!string.IsNullOrEmpty(version))
            {
                return version;
            }

            var fileVersionAttribute = assembly.GetCustomAttribute<AssemblyFileVersionAttribute>();

            version = fileVersionAttribute?.Version;

            if (!string.IsNullOrEmpty(version))
            {
                return version;
            }

            var versionAttribute = assembly.GetCustomAttribute<AssemblyVersionAttribute>();

            if (versionAttribute != null)
            {
                version = versionAttribute.Version;

                return version ?? string.Empty;
            }
            else
            {
                return string.Empty;
            }
            
        });
    }
}

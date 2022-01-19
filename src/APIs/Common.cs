using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace MLTDABD.APIs
{
    internal class Common
    {
        static Common()
        {
            var messageHandler = new HttpClientHandler();
            InternalHttpClient = new HttpClient(messageHandler);
        }

        public static HttpClient HttpClient
        {
            [DebuggerStepThrough]
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => InternalHttpClient;
        }

        private static readonly HttpClient InternalHttpClient;

    }
}

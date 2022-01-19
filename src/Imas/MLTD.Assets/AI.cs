namespace MLTD.Assets
{
    public sealed class AssetInfo
    {

        public AssetInfo(string resourceName, string contentHash, string remoteName, uint size)
        {
            ResourceName = resourceName;
            ContentHash = contentHash;
            RemoteName = remoteName;
            Size = size;
        }

        public string ResourceName { get; }

        public string ContentHash { get; }

        public string RemoteName { get; }

        /// <summary>
        /// Size in bytes.
        /// </summary>
        public uint Size { get; }

    }
}

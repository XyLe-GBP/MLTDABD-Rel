using JetBrains.Annotations;

namespace MLTD.Assets
{
    public sealed partial class AssetInfoList
    {

        public AssetInfoList()
        {
            Assets = new List<AssetInfo>();
        }

        public AssetInfoList([NotNull, ItemNotNull] IEnumerable<AssetInfo> assets)
        {
            Assets = new List<AssetInfo>(assets);
        }

        [NotNull, ItemNotNull]
        public List<AssetInfo> Assets { get; }

    }
}

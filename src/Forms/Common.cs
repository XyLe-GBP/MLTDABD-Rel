using JetBrains.Annotations;
using MLTD.Assets;
using MLTDABD.APIs;
using System.Text.RegularExpressions;

namespace MLTDABD.Forms
{
    public sealed class DownloadConfig
    {

        internal DownloadConfig([NotNull] string host, [NotNull] string unityVersion, int resourceVersion, bool isLatest, UMPF platform, [NotNull] string manifestAssetName)
        {
            Host = host;
            UnityVersion = unityVersion;
            ResourceVersion = resourceVersion;
            IsLatest = isLatest;
            Platform = platform;
            ManifestAssetName = manifestAssetName;
        }

        /// <summary>
        /// ホスト
        /// </summary>
        [NotNull]
        public string Host { get; }

        /// <summary>
        /// Unityのバージョン
        /// </summary>
        [NotNull]
        public string UnityVersion { get; }

        /// <summary>
        /// マニフェストのバージョン
        /// </summary>
        public int ResourceVersion { get; }

        /// <summary>
        /// 最新バージョンか否かのフラグ
        /// </summary>
        public bool IsLatest { get; }

        /// <summary>
        /// プラットフォーム
        /// </summary>
        public UMPF Platform { get; }

        /// <summary>
        /// マニフェストの生の名前 ( {ハッシュ値}.data )
        /// </summary>
        [NotNull]
        public string ManifestAssetName { get; }

    }
    public sealed class ManifestOpening
    {

        private ManifestOpening(bool isLocal, string filePath, int version, bool isLatest)
        {
            IsLocal = isLocal;
            FilePath = filePath;
            Version = version;
            IsLatest = isLatest;
        }

        public bool IsLocal { get; }

        public bool IsLatest { get; }

        public string FilePath { get; }

        public int Version { get; }

        internal static ManifestOpening Local(string filePath)
        {
            return new ManifestOpening(true, filePath, 0, false);
        }

        internal static ManifestOpening Remote(int version, bool isLatest)
        {
            return Remote(version, isLatest, null!);
        }

        internal static ManifestOpening Remote(int version, bool isLatest, string filePath)
        {
            return new ManifestOpening(false, filePath ?? string.Empty, version, isLatest);
        }

    }

    public sealed class TreeListItem
    {

        public TreeListItem([NotNull] AssetInfo assetInfo)
        {
            _assetInfo = assetInfo;
        }

        [NotNull]
        public string LocalName
        {
            get => _assetInfo.ResourceName;
        }

        [NotNull]
        public string RemoteName
        {
            get => _assetInfo.RemoteName;
        }

        public uint Size
        {
            get => _assetInfo.Size;
        }

        [NotNull]
        public string Hash
        {
            get => _assetInfo.ContentHash;
        }

        [NotNull, ItemNotNull]
        public string[] GetCategoryHierarchy()
        {
            if (_categoryHierarchy != null)
            {
                return _categoryHierarchy;
            }

            var hierarchy = Categorize(_assetInfo.ResourceName);

            _categoryHierarchy = hierarchy;

            return hierarchy;
        }

        [NotNull, ItemNotNull]
        private static string[] Categorize([NotNull] string localName)
        {
            var hierarchy = new List<string>();
            var categorized = false;

            if (localName.Length > 6)
            {
                var match = CharaSerialRegex.Match(localName);

                if (match.Success)
                {
                    hierarchy.Add("[001har]");
                    hierarchy.Add(match.Value);
                    categorized = true;
                }
            }

            if (!categorized)
            {
                if (!localName.Contains('_'))
                {
                    // Some special cases
                    {
                        if (localName.StartsWith("tutorialinfo", StringComparison.Ordinal))
                        {
                            hierarchy.Add("tutorial");
                            categorized = true;
                        }
                        else if (localName.StartsWith("tuna", StringComparison.Ordinal))
                        {
                            hierarchy.Add("tuna");
                            categorized = true;
                        }
                        else if (localName.StartsWith("yokosuka", StringComparison.Ordinal))
                        {
                            hierarchy.Add("yokosuka");
                            categorized = true;
                        }
                        else if (localName.StartsWith("costumesalesinfo", StringComparison.Ordinal))
                        {
                            hierarchy.Add("costume");
                            categorized = true;
                        }
                        else if (localName.StartsWith("selection", StringComparison.Ordinal))
                        {
                            hierarchy.Add("selection");
                            categorized = true;
                        }
                        else if (localName.StartsWith("streaming", StringComparison.Ordinal))
                        {
                            hierarchy.Add("streaming");
                            categorized = true;
                        }
                        else if (localName.StartsWith("fortune", StringComparison.Ordinal))
                        {
                            hierarchy.Add("fortune");
                            categorized = true;
                        }
                        else if (localName.StartsWith("salmon", StringComparison.Ordinal))
                        {
                            hierarchy.Add("salmon");
                            categorized = true;
                        }
                        else if (localName.StartsWith("oyster", StringComparison.Ordinal))
                        {
                            hierarchy.Add("oyster");
                            categorized = true;
                        }
                    }
                }
            }

            var relPath = localName;

            if (!categorized)
            {
                // Some special cases
                {
                    string subCat;

                    if (localName.StartsWith("stage", StringComparison.Ordinal))
                    {
                        if (localName.Length > 8 && char.IsDigit(localName, 5) && char.IsDigit(localName, 6) && char.IsDigit(localName, 7))
                        {
                            // ^stage[\d]{3}
                            hierarchy.Add("stage");
                            // Begins from "000" in "stage000_xxxx.unity3d"
                            relPath = localName[5..];
                        }
                        else if (localName.StartsWith("stage2d", StringComparison.Ordinal))
                        {
                            if (localName.Equals("stage2d.unity3d", StringComparison.Ordinal))
                            {
                                hierarchy.Add("stage2d");
                                categorized = true;
                            }
                        }
                    }
                    else if (localName.StartsWith("ex4c", StringComparison.Ordinal))
                    {
                        subCat = localName.Substring(4, 5);
                        hierarchy.Add("ex4c");
                        hierarchy.Add(subCat);
                        categorized = true;
                    }
                    else if (localName.StartsWith("exwb", StringComparison.Ordinal))
                    {
                        subCat = localName.Substring(4, 7);
                        hierarchy.Add("exwb");
                        hierarchy.Add(subCat);
                        categorized = true;
                    }
                    else if (localName.StartsWith("blog", StringComparison.Ordinal))
                    {
                        hierarchy.Add("blog");
                        categorized = true;
                    }
                    else if (localName.StartsWith("gasha", StringComparison.Ordinal))
                    {
                        subCat = localName.Substring(5, 5);
                        hierarchy.Add("gasha");
                        hierarchy.Add(subCat);
                        categorized = true;
                    }
                    else if (localName.StartsWith("room", StringComparison.Ordinal))
                    {
                        hierarchy.Add("room");

                        if (localName.Contains('_'))
                        {
                            relPath = localName[4..];
                        }
                        else
                        {
                            subCat = localName.Substring(4, 3);
                            hierarchy.Add(subCat);
                        }
                    }
                    else if (localName.StartsWith("eventop", StringComparison.Ordinal))
                    {
                        subCat = localName.Substring(7, 4);
                        hierarchy.Add("eventop");
                        hierarchy.Add(subCat);
                        categorized = true;
                    }
                    else if (localName.StartsWith("event", StringComparison.Ordinal))
                    {
                        hierarchy.Add("event");

                        if (localName[5] == '_')
                        {
                            if (char.IsDigit(localName, 6) && char.IsDigit(localName, 7) && char.IsDigit(localName, 8) && char.IsDigit(localName, 9))
                            {
                                // ^event_[\d]{4}
                                subCat = localName.Substring(6, 4);
                                hierarchy.Add(subCat);
                                categorized = true;
                            }
                            else
                            {
                                relPath = localName[6..];
                            }
                        }
                        else
                        {
                            categorized = true;
                        }
                    }
                }
            }

            // Now these are real "miscellaneous" assets
            if (!categorized && !localName.Contains('_') && hierarchy.Count == 0)
            {
                hierarchy.Add("[misc]");
                categorized = true;
            }

            if (!categorized)
            {
                var parts = relPath.Split(LocalPartSeparator);

                // We don't want the last part
                for (var i = 0; i < parts.Length - 1; i += 1)
                {
                    hierarchy.Add(parts[i]);
                }
            }

            return hierarchy.ToArray();
        }

        [NotNull]
        private static readonly Regex CharaSerialRegex = new(@"^[\d]{3}[a-z]{3}", RegexOptions.CultureInvariant | RegexOptions.Compiled);

        [NotNull]
        private static readonly char[] LocalPartSeparator = { '_' };

        [NotNull]
        private readonly AssetInfo _assetInfo;

        [CanBeNull, ItemNotNull]
        private string[]? _categoryHierarchy;

    }

    public enum TreeListView
    {

        ListView = 0,

        TreeView = 1,

    }

    public sealed class Utils
    {
    }
}

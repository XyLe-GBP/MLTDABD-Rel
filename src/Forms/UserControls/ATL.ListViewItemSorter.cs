using JetBrains.Annotations;
using System.Collections;
using System.Diagnostics;

namespace MLTDABD.Forms
{
    partial class AssetTreeList
    {

        private sealed class ListViewItemSorter : IComparer
        {

            private ListViewItemSorter()
            {
            }

            public int Compare(object? x, object? y)
            {
                var a = x as ListViewItem;

                Debug.Assert(a != null, nameof(a) + " != null");

                var b = y as ListViewItem;

                Debug.Assert(b != null, nameof(b) + " != null");

                return string.CompareOrdinal(a.Text, b.Text);
            }

            [NotNull]
            public static readonly ListViewItemSorter Instance = new();

        }
    }
}

﻿using JetBrains.Annotations;
using System.Collections;
using System.Diagnostics;

namespace MLTDABD.Forms
{
    partial class AssetTreeList
    {

        private sealed class TreeNodeSorter : IComparer
        {

            private TreeNodeSorter()
            {
            }

            public int Compare(object? x, object? y)
            {
                var a = x as TreeNode;

                Debug.Assert(a != null, nameof(a) + " != null");

                var b = y as TreeNode;

                Debug.Assert(b != null, nameof(b) + " != null");

                return string.CompareOrdinal(a.Text, b.Text);
            }

            [NotNull]
            public static readonly TreeNodeSorter Instance = new();

        }

    }
}

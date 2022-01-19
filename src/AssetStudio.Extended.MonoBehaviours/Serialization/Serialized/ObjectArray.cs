﻿using System;
using JetBrains.Annotations;

namespace AssetStudio.Extended.MonoBehaviours.Serialization.Serialized {
    public sealed class ObjectArray {

        internal ObjectArray([NotNull, ItemCanBeNull] object[] array, [NotNull] Type elementType) {
            Array = array;
            ElementType = elementType;
        }

        [NotNull, ItemCanBeNull]
        public object[] Array { get; }

        /// <summary>
        /// Element type. Can be primitive types (including string), <see cref="CustomType"/> (typed object), <see cref="ObjectArray"/> (array), <see cref="ObjectDictionary"/> (dictionary),
        /// <see cref="RawData"/> (byte array), or <see cref="object"/> (unknown type, usually means the collection is empty).
        /// </summary>
        [NotNull]
        public Type ElementType { get; }

    }
}

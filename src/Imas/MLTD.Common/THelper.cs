﻿using JetBrains.Annotations;
using MLTD.Entities;
using System.Runtime.CompilerServices;

namespace MLTD
{
    public static class TheaterHelper
    {

        public static ushort SwapEndian(ushort v)
        {
            var r = (ushort)(v & 0xff);
            r <<= 8;
            v >>= 8;
            r |= (ushort)(v & 0xff);
            return r;
        }

        public static short SwapEndian(short v)
        {
            unchecked
            {
                var s = (ushort)v;
                return (short)SwapEndian(s);
            }
        }

        public static uint SwapEndian(uint v)
        {
            var r = v & 0xff;
            r <<= 8;
            v >>= 8;
            r |= v & 0xff;
            r <<= 8;
            v >>= 8;
            r |= v & 0xff;
            r <<= 8;
            v >>= 8;
            r |= v & 0xff;
            return r;
        }

        public static int SwapEndian(int v)
        {
            unchecked
            {
                var s = (uint)v;
                return (int)SwapEndian(s);
            }
        }

        public static ulong SwapEndian(ulong v)
        {
            var r = v & 0xff;
            r <<= 8;
            v >>= 8;
            r |= v & 0xff;
            r <<= 8;
            v >>= 8;
            r |= v & 0xff;
            r <<= 8;
            v >>= 8;
            r |= v & 0xff;
            r <<= 8;
            v >>= 8;
            r |= v & 0xff;
            r <<= 8;
            v >>= 8;
            r |= v & 0xff;
            r <<= 8;
            v >>= 8;
            r |= v & 0xff;
            r <<= 8;
            v >>= 8;
            r |= v & 0xff;
            return r;
        }

        public static long SwapEndian(long v)
        {
            unchecked
            {
                var s = (ulong)v;
                return (long)SwapEndian(s);
            }
        }

        public static float SwapEndian(float v)
        {
            var bytes = BitConverter.GetBytes(v);
            var b = bytes[0];
            bytes[0] = bytes[1];
            bytes[1] = b;
            b = bytes[2];
            bytes[2] = bytes[3];
            bytes[3] = b;
            return BitConverter.ToSingle(bytes, 0);
        }

        public static double SwapEndian(double v)
        {
            var bytes = BitConverter.GetBytes(v);
            Array.Reverse(bytes);
            return BitConverter.ToDouble(bytes, 0);
        }

        public static void Swap<T>(ref T t1, ref T t2)
        {
            var t = t1;
            t1 = t2;
            t2 = t;
        }

        [NotNull]
        public static string GenerateRandomLowerCaseBytesHash(int bytesLength)
        {
            var bytes = new byte[bytesLength];

            MathUtilities.Random.NextBytes(bytes);

            return string.Join(string.Empty, bytes.Select(b => b.ToString("x2")));
        }

        /// <summary>
        /// Returns common form like "001har", "002chi".
        /// </summary>
        /// <param name="idolID">Idol index, starting from 0.</param>
        /// <returns></returns>
        [NotNull]
        public static string GetIdolSerialAbbreviation(int idolID)
        {
            var idolInfo = MltdConstants.Idols.SingleOrDefault(info => info.IdolID == idolID);

            if (idolInfo == null)
            {
                throw new ArgumentException($"Idol with Mst ID {idolID} is not found.", nameof(idolID));
            }

            return GetIdolSerialAbbreviation(idolInfo);
        }

        [NotNull]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string GetIdolSerialAbbreviation([NotNull] IdolInfo idolInfo)
        {
            return idolInfo.IdolID.ToString("000") + idolInfo.Abbreviation;
        }

    }
}

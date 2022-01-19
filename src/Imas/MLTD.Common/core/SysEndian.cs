namespace MLTD.Core
{
    public static class SystemEndian
    {

        public static readonly Endian Type = BitConverter.IsLittleEndian ? Endian.LittleEndian : Endian.BigEndian;

    }
}
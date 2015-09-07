using System.Runtime.InteropServices;

namespace MumbleLink_CSharp_GW2
{

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct GW2Context
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
        public readonly byte[] ServerAddress;

        public readonly uint MapId;
        public readonly uint MapType;
        public readonly uint ShardId;
        public readonly uint Instance;
        public readonly uint BuildId;
    }
}
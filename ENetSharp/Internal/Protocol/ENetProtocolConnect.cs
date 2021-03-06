﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ENetSharp.Internal.Protocol
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct ENetProtocolConnect
    {
        public ENetProtocolCommandHeader Header;
        public byte OutgoingPeerID;
        public ushort MTU;
        public uint WindowSize;
        public uint ChannelCount;
        public uint IncomingBandwidth;
        public uint OutgoingBandwidth;
        public uint PacketThrottleInterval;
        public uint PacketThrottleAcceleration;
        public uint PacketThrottleDeceleration;
        public uint SessionID;
    }
}

﻿#if CLIENT || SERVER
using System;

namespace OTA.Plugin
{
    public static partial class HookArgs
    {
        public struct ReceiveNetMessage
        {
            public int BufferId { get; set; }

            public byte PacketId { get; set; }

            public int Start { get; set; }

            public int Length { get; set; }
        }
    }

    public static partial class HookPoints
    {
        public static readonly HookPoint<HookArgs.ReceiveNetMessage> ReceiveNetMessage = new HookPoint<HookArgs.ReceiveNetMessage>();
    }
}
#endif
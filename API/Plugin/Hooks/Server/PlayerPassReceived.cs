﻿#if SERVER
using System;

namespace OTA.Plugin
{
    public static partial class HookArgs
    {
        /// <summary>
        /// Player pass received data.
        /// </summary>
        public struct PlayerPassReceived
        {
            /// <summary>
            /// The players password
            /// </summary>
            public string Password { get; set; }
        }
    }

    public static partial class HookPoints
    {
        /// <summary>
        /// Occurs when OTA has asked the player for a password (not the server password).
        /// </summary>
        /// <description>
        /// There are multiple HookContext.Result states accepted:
        ///     1) ASK_PASS to re-prompt for the password
        ///     2) KICK to remove the player/connection. Typically used via HookContext.SetKick.
        /// Any other state will accept the connection.
        /// See the HookContext instance for the player and connection instances
        /// </description>
        public static readonly HookPoint<HookArgs.PlayerPassReceived> PlayerPassReceived = new HookPoint<HookArgs.PlayerPassReceived>();
    }
}
#endif
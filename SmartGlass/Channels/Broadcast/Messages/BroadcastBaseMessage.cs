﻿
namespace SmartGlass.Channels.Broadcast.Messages
{
    /// <summary>
    /// All broadcast messages derive from this
    /// </summary>
    public class BroadcastBaseMessage
    {
        /// <summary>
        /// Type of Broadcast message
        /// </summary>
        /// <value>Broadcast message type</value>
        public BroadcastMessageType Type { get; set; }
    }
}

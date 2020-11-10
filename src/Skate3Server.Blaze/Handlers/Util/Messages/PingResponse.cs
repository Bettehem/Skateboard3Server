﻿using Skate3Server.Blaze.Serializer.Attributes;
using Skate3Server.Blaze.Server;

namespace Skate3Server.Blaze.Handlers.Util.Messages
{
    [BlazeResponse(BlazeComponent.Util, (ushort)UtilCommand.Ping)]
    public class PingResponse : BlazeResponse
    {
        [TdfField("STIM")]
        public uint Timestamp { get; set; }
    }
}

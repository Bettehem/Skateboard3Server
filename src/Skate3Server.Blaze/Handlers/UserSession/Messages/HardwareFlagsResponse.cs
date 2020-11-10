﻿using Skate3Server.Blaze.Serializer.Attributes;
using Skate3Server.Blaze.Server;

namespace Skate3Server.Blaze.Handlers.UserSession.Messages
{
    [BlazeResponse(BlazeComponent.UserSession, (ushort)UserSessionCommand.HardwareFlags)]
    public class HardwareFlagsResponse : BlazeResponse
    {
    }
}

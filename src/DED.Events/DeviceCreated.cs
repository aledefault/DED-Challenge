using DED.Domain;
using NServiceBus;
using System;

namespace DED.Events
{
    public class DeviceCreated : IEvent
    {
        public Device Device { get; set; }
    }
}

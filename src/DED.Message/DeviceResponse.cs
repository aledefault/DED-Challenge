using System.Collections.Generic;
using NServiceBus;

namespace DED.Message
{
    public class DeviceResponse : IMessage
    {
        public bool Success { get; set; }
        public List<string> Messages { get; set; }
    }
}

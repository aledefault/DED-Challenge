using DED.Domain;
using NServiceBus;

namespace DED.Message
{
    public class DeviceCreate : ICommand
    {
        public Device Device { get; set; }
    }
}

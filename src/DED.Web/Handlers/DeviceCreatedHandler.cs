using DED.Events;
using DED.Web.Services;
using Microsoft.Extensions.Logging;
using NServiceBus;
using System.Threading.Tasks;

namespace DED.Web.Handlers
{
    public class DeviceCreatedHandler : IHandleMessages<DeviceCreated>
    {
        private ILogger<DeviceCreatedHandler> _logger;
        private DeviceCreatedEventService _deviceCreated;

        public DeviceCreatedHandler(ILogger<DeviceCreatedHandler> logger, DeviceCreatedEventService deviceCreated)
        {
            _logger = logger;
            _deviceCreated = deviceCreated;
        }

        public Task Handle(DeviceCreated message, IMessageHandlerContext context)
        {
            _logger.LogInformation($"Device {message.Device} created.");
            _deviceCreated.Publish(message.Device);
            return Task.CompletedTask;
        }
    }
}

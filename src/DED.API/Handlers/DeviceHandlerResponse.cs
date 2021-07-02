using DED.Messages;
using Microsoft.Extensions.Logging;
using NServiceBus;
using System.Threading.Tasks;

//TODO: Implement a SignalR Hub to inform to the clients.
namespace DED.API.Handlers
{
    public class DeviceHandlerResponse :
        IHandleMessages<DeviceResponse>
    {
        private readonly ILogger<DeviceHandlerResponse> _logger;

        public DeviceHandlerResponse(ILogger<DeviceHandlerResponse> logger) => _logger = logger;

        public Task Handle(DeviceResponse message, IMessageHandlerContext context)
        {
            _logger.LogInformation("Receiving Device response...");
            _logger.LogInformation(message.Success.ToString());
            return Task.CompletedTask;
        }
    }
}

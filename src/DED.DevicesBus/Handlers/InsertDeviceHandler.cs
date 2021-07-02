using DED.Events;
using DED.Messages;
using MediatR;
using Microsoft.Extensions.Logging;
using NServiceBus;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DED.DevicesBus.Handlers
{
    public class InsertDeviceHandler :
        IHandleMessages<CreateDevice>
    {
        private readonly ILogger<InsertDeviceHandler> _logger;
        private readonly IMediator _mediator;

        public InsertDeviceHandler(ILogger<InsertDeviceHandler> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        public async Task Handle(CreateDevice deviceCreate, IMessageHandlerContext context)
        {
            try
            {
                if (!deviceCreate.Device.IsValid())
                {
                    await ErrorReply($"{nameof(deviceCreate.Device)} is not valid.", context);
                    return;
                }

                _logger.LogInformation($"Saving {deviceCreate.Device.GetType().Name}...");

                var result = await _mediator.Send(new CreateDeviceCommand.Command(deviceCreate.Device));
                await context.Publish(new DeviceCreated { Device = result }).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                await ErrorReply(e.Message, context);
                _logger.LogError(e.Message, e);
                return;
            }
        }

        private static async Task ErrorReply(string message, IMessageHandlerContext context)
        {
            await context.Reply(new DeviceResponse
            {
                Success = false,
                Messages = new List<string>() { message }
            });
        }
    }
}

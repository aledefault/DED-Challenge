using DED.Message;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NServiceBus;
using System;
using System.Threading.Tasks;

namespace DED.API.Features.Gateway
{
    [ApiController]
    [Route("api/v1/[controller]")]
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public class GatewayController : ControllerBase
    {
        private readonly IMessageSession _messageSession;
        private readonly ILogger<GatewayController> _logger;
        private readonly IMediator _mediator;

        public GatewayController(IMessageSession messageSession, IMediator mediator, ILogger<GatewayController> logger)
        {
            _logger = logger;
            _mediator = mediator;
            _messageSession = messageSession;
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var result = await _mediator.Send(new GetGatewayQuery.Query(id));
            return result != null ? Ok(result) : NotFound();
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetAllGatewaysQuery.Query());
            return result != null ? Ok(result) : NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Create(GatewayModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var result = await _mediator.Send(new GetGatewayQueryBySerialNumber.Query(model.SerialNumber));
            if (result != null)
                return Conflict();

            var command = new DeviceCreate
            {
                Device = new Domain.Gateway(Guid.NewGuid(), model.SerialNumber, model.Ip, model.Port, model.Brand, model.Model)
            };

            await _messageSession.Send(command).ConfigureAwait(false);

            _logger.LogInformation($"Sending Gateway {command.Device.Id} ...");

            return Ok();
        }
    }
}

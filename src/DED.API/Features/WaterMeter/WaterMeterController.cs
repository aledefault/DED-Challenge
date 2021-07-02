using DED.Messages;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NServiceBus;
using System;
using System.Threading.Tasks;

namespace DED.API.Features.WaterMeter
{
    [ApiController]
    [Route("api/v1/[controller]")]
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public class WaterMeterController : ControllerBase
    {
        private readonly IMessageSession _messageSession;
        private readonly ILogger<WaterMeterController> _logger;
        private readonly IMediator _mediator;

        public WaterMeterController(IMessageSession messageSession, IMediator mediator, ILogger<WaterMeterController> logger)
        {
            _logger = logger;
            _mediator = mediator;
            _messageSession = messageSession;
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var result = await _mediator.Send(new GetWaterMeterQuery.Query(id));
            return result != null ? Ok(result) : NotFound();
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetAllWaterMetersQuery.Query());
            return result != null ? Ok(result) : NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Create(WaterMeterModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var result = await _mediator.Send(new GetWaterMeterBySerialNumberQuery.Query(model.SerialNumber));
            if (result != null)
                return Conflict();

            var command = new CreateDevice
            {
                Device = new Domain.WaterMeter(Guid.NewGuid(), model.SerialNumber, model.Brand, model.Model)
            };

            await _messageSession.Send(command).ConfigureAwait(false);

            _logger.LogInformation($"Sending WaterMeter {command.Device.Id} ...");

            return Ok();
        }
    }
}

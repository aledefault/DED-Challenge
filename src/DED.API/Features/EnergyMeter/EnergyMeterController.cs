﻿using DED.Message;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NServiceBus;
using System;
using System.Threading.Tasks;

namespace DED.API.Features.EnergyMeter
{
    [ApiController]
    [Route("api/v1/[controller]")]
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public class EnergyMeterController : ControllerBase
    {
        private readonly IMessageSession _messageSession;
        private readonly ILogger<EnergyMeterController> _logger;
        private readonly IMediator _mediator;

        public EnergyMeterController(IMessageSession messageSession, IMediator mediator, ILogger<EnergyMeterController> logger)
        {
            _logger = logger;
            _mediator = mediator;
            _messageSession = messageSession;
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var result = await _mediator.Send(new GetEnergyMeterQuery.Query(id));
            return result != null ? Ok(result) : NotFound();
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetAllEnergyMetersQuery.Query());
            return result != null ? Ok(result) : NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Create(EnergyMeterModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var result = await _mediator.Send(new GetEnergyMeterQueryBySerialNumber.Query(model.SerialNumber));
            if (result != null)
                return Conflict();

            var command = new DeviceCreate
            {
                Device = new Domain.EnergyMeter(Guid.NewGuid(), model.SerialNumber, model.Brand, model.Model)
            };

            await _messageSession.Send(command).ConfigureAwait(false);

            _logger.LogInformation($"Sending EnegeryMeter {command.Device.Id} ...");

            return Ok();
        }
    }
}

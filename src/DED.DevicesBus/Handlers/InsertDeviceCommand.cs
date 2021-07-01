using System;
using System.Threading;
using System.Threading.Tasks;
using DED.DevicesBus.Services;
using DED.Domain;
using MediatR;
using MongoDB.Driver;

namespace DED.DevicesBus.Handlers
{
    public static class CreateDeviceCommand
    {
        public record Command(Device Device) : IRequest<Device> { }

        public class CommandHandler : IRequestHandler<Command, Device>
        {
            private readonly MongoDbService _mongoDbService;

            public CommandHandler(MongoDbService mongoDbService) => _mongoDbService = mongoDbService;

            public async Task<Device> Handle(Command request, CancellationToken cancellationToken)
            {
                var collection = _mongoDbService.GetDatabase().GetCollection<Device>(request.Device.GetType().Name);

                var filter = new FilterDefinitionBuilder<Device>().Or(
                    new FilterDefinitionBuilder<Device>().Eq("Id", request.Device.Id),
                    new FilterDefinitionBuilder<Device>().Eq("SerialNumber", request.Device.SerialNumber)
                );

                var options = new FindOneAndReplaceOptions<Device, Device> { IsUpsert = true, ReturnDocument = ReturnDocument.After };

                var result = await collection.FindOneAndReplaceAsync(filter, request.Device, options, cancellationToken);
                return result;
            }
        }
    }
}
using System.Threading;
using System.Threading.Tasks;
using DED.API.Services;
using MediatR;
using MongoDB.Driver;

namespace DED.API.Features.WaterMeter
{
    public class GetWaterMeterQueryBySerialNumber
    {
        public record Query(string SerialNumber) : IRequest<Domain.WaterMeter> { }

        public class Handler : IRequestHandler<Query, Domain.WaterMeter>
        {
            private readonly IMongoCollection<Domain.WaterMeter> _collection;

            public Handler(MongoDbService mongoService) => _collection = mongoService.GetCollection<Domain.WaterMeter>();

            public async Task<Domain.WaterMeter> Handle(Query request, CancellationToken cancellationToken)
            {
                var result = await _collection.FindAsync(device => device.SerialNumber.Equals(request.SerialNumber), cancellationToken: cancellationToken);
                return await result.FirstOrDefaultAsync(cancellationToken);
            }
        }
    }
}

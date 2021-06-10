using System;
using System.Threading;
using System.Threading.Tasks;
using DED.API.Services;
using MediatR;
using MongoDB.Driver;

namespace DED.API.Features.WaterMeter
{
    public class WaterMeterQuery
    {
        public record Query(Guid Id) : IRequest<Domain.WaterMeter> { }

        public class Handler : IRequestHandler<Query, Domain.WaterMeter>
        {
            private readonly IMongoCollection<Domain.WaterMeter> _collection;

            public Handler(MongoDbService mongoService) => _collection = mongoService.GetCollection<Domain.WaterMeter>();

            public async Task<Domain.WaterMeter> Handle(Query request, CancellationToken cancellationToken)
            {
                var result = await _collection.FindAsync(device => device.Id == request.Id, cancellationToken: cancellationToken);
                return await result.FirstOrDefaultAsync(cancellationToken);
            }
        }
    }
}

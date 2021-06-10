using System;
using System.Threading;
using System.Threading.Tasks;
using DED.API.Services;
using MediatR;
using MongoDB.Driver;

namespace DED.API.Features.EnergyMeter
{
    public class GetEnergyMeterQuery
    {
        public record Query(Guid Id) : IRequest<Domain.EnergyMeter> { }

        public class Handler : IRequestHandler<Query, Domain.EnergyMeter>
        {
            private readonly IMongoCollection<Domain.EnergyMeter> _collection;

            public Handler(MongoDbService mongoService) => _collection = mongoService.GetCollection<Domain.EnergyMeter>();

            public async Task<Domain.EnergyMeter> Handle(Query request, CancellationToken cancellationToken)
            {
                var result = await _collection.FindAsync(device => device.Id == request.Id, cancellationToken: cancellationToken);
                return await result.FirstOrDefaultAsync(cancellationToken);
            }
        }
    }
}

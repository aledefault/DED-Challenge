using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using DED.API.Services;
using MediatR;
using MongoDB.Driver;

namespace DED.API.Features.EnergyMeter
{
    public class GetAllEnergyMetersQuery
    {
        public record Query() : IRequest<IEnumerable<Domain.EnergyMeter>> { }

        public class Handler : IRequestHandler<Query, IEnumerable<Domain.EnergyMeter>>
        {
            private readonly IMongoCollection<Domain.EnergyMeter> _collection;

            public Handler(MongoDbService mongoService) => _collection = mongoService.GetCollection<Domain.EnergyMeter>();

            public async Task<IEnumerable<Domain.EnergyMeter>> Handle(Query request, CancellationToken cancellationToken)
            {
                var result = await _collection.FindAsync(
                    FilterDefinition<Domain.EnergyMeter>.Empty,
                    cancellationToken: cancellationToken);

                return await result.ToListAsync(cancellationToken);
            }
        }
    }
}

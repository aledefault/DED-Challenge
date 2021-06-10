using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using DED.API.Services;
using MediatR;
using MongoDB.Driver;

namespace DED.API.Features.WaterMeter
{
    public class WaterMetersQuery
    {
        public record Query() : IRequest<IEnumerable<Domain.WaterMeter>> { }

        public class Handler : IRequestHandler<Query, IEnumerable<Domain.WaterMeter>>
        {
            private readonly IMongoCollection<Domain.WaterMeter> _collection;

            public Handler(MongoDbService mongoService) => _collection = mongoService.GetCollection<Domain.WaterMeter>();

            public async Task<IEnumerable<Domain.WaterMeter>> Handle(Query request, CancellationToken cancellationToken)
            {
                var result = await _collection.FindAsync(
                    FilterDefinition<Domain.WaterMeter>.Empty,
                    cancellationToken: cancellationToken);

                return await result.ToListAsync(cancellationToken);
            }
        }
    }
}

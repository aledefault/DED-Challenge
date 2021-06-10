using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using DED.API.Services;
using MediatR;
using MongoDB.Driver;

namespace DED.API.Features.Gateway
{
    public class GetAllGatewaysQuery
    {
        public record Query() : IRequest<IEnumerable<Domain.Gateway>> { }

        public class Handler : IRequestHandler<Query, IEnumerable<Domain.Gateway>>
        {
            private readonly IMongoCollection<Domain.Gateway> _collection;

            public Handler(MongoDbService mongoService) => _collection = mongoService.GetCollection<Domain.Gateway>();

            public async Task<IEnumerable<Domain.Gateway>> Handle(Query request, CancellationToken cancellationToken)
            {
                var result = await _collection.FindAsync(
                    FilterDefinition<Domain.Gateway>.Empty,
                    cancellationToken: cancellationToken);

                return await result.ToListAsync(cancellationToken);
            }
        }
    }
}

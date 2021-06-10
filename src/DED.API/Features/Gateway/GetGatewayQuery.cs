using System;
using System.Threading;
using System.Threading.Tasks;
using DED.API.Services;
using MediatR;
using MongoDB.Driver;

namespace DED.API.Features.Gateway
{
    public class GetGatewayQuery
    {
        public record Query(Guid Id) : IRequest<Domain.Gateway> { }

        public class Handler : IRequestHandler<Query, Domain.Gateway>
        {
            private readonly IMongoCollection<Domain.Gateway> _collection;

            public Handler(MongoDbService mongoService) => _collection = mongoService.GetCollection<Domain.Gateway>();

            public async Task<Domain.Gateway> Handle(Query request, CancellationToken cancellationToken)
            {
                var result = await _collection.FindAsync(device => device.Id == request.Id, cancellationToken: cancellationToken);
                return await result.FirstOrDefaultAsync(cancellationToken);
            }
        }
    }
}

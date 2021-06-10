using System;

namespace DED.Domain
{
    public interface IIdentity
    {
        public Guid Id { get; init; }
    }
}

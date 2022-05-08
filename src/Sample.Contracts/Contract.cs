using System;

namespace Sample.Contracts
{
    public interface Contract
    {
        DateTime Timestamp { get; }
        Guid CorrelationId { get; }
    }
}

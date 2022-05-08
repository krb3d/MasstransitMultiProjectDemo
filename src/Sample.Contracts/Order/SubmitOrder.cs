using System;

namespace Sample.Contracts.Order
{
    public interface SubmitOrder
    {
        DateTime Timestamp { get; }
        Guid CorrelationId { get; }
        Guid OrderId { get; }
        string CustomerNumber { get; }
    }
}

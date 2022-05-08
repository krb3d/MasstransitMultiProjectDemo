using System;

namespace Sample.Contracts.Order
{
    public interface OrderSubmissionAccepted : Contract
    {
        Guid OrderId { get; }
        string CustomerNumber { get; }
    }
}

using MassTransit;
using Sample.Contracts.Order;
using System;
using System.Threading.Tasks;

namespace Sample.Components.Consumers
{
    public class SubmitOrderConsumer : IConsumer<SubmitOrder>
    {
        public async Task Consume(ConsumeContext<SubmitOrder> context)
        {
            await context.RespondAsync<OrderSubmissionAccepted>(
                new
                {
                    Timestamp = InVar.Timestamp,
                    CorrelationId = context.Message.CorrelationId,
                    OrderId = context.Message.OrderId,
                    CustomerNumber = context.Message.CustomerNumber,
                });
        }
    }
}

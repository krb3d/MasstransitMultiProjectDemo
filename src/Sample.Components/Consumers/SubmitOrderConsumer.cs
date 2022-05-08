using MassTransit;
using Sample.Contracts;
using System;
using System.Threading.Tasks;

namespace Sample.Components.Consumers
{
    public class SubmitOrderConsumer : IConsumer<SubmitOrder>
    {
        public async Task Consume(ConsumeContext<SubmitOrder> context)
        {
            throw new NotImplementedException();
        }
    }
}

using MassTransit;
using Microsoft.AspNetCore.Mvc;
using Sample.Contracts;
using Sample.Contracts.Order;

namespace Sample.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class OrderController : ControllerBase
{
    private readonly ILogger<OrderController> _logger;
    private readonly IRequestClient<SubmitOrder> _submitOrderRequestClient;

    public OrderController(
        ILogger<OrderController> logger,
        IRequestClient<SubmitOrder> submitOrderRequestClient)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _submitOrderRequestClient = submitOrderRequestClient ?? throw new ArgumentNullException(nameof(submitOrderRequestClient));
    }

    [HttpPost(Name = "Order")]
    public async Task<IActionResult> Post(
                    Guid id,
                    string customerNumber)
    {
        var response = await _submitOrderRequestClient.GetResponse<OrderSubmissionAccepted>(new
        {
            Timestamp = InVar.Timestamp,
            CorrelationId = InVar.CorrelationId,
            OrderId = id,
            CustomerNumber = customerNumber,
        });

        return Ok(response.Message);
    }
}

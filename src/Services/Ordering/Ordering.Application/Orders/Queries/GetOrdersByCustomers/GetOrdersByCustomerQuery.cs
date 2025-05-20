namespace Ordering.Application.Orders.Queries.GetOrdersByCustomers
{
    public record GetOrdersByCustomerQuery(Guid CustomerId)
        :IQuery<GetOrdersByCustomerResult>;

    public record GetOrdersByCustomerResult(IEnumerable<OrderDto> Orders);
}

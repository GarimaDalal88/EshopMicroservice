
using Ordering.Application.Orders.Commands.DeleteOrder;

namespace Ordering.API.Endpoints
{
    //Accept the order ID as a parameter
    //Construct a DeleteOrderCommand
    //Send the command using MediatR
    //Returns a sucess or not found response

    //public record DeleteOrderRequest(Guid Id);
    public record DeleteOrderResponse(bool IsSucess);
    public class DeleteOrder : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapDelete("/orders/{id}", async (Guid Id, ISender sender) =>
            {
                var result = await sender.Send(new DeleteOrderCommand(Id));

                var response = result.Adapt<DeleteOrderResponse>();

                return Results.Ok(response);
            })
            .WithName("Delete Order")
            .Produces<DeleteOrderResponse>(StatusCodes.Status201Created)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .ProducesProblem(StatusCodes.Status404NotFound)
            .WithSummary("Delete Order")
            .WithDescription("Delete Order");
        }
    }
}

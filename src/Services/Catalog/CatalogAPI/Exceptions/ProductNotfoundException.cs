using BuildingBlocks.Exceptions;

namespace CatalogAPI.Exceptions
{
    public class ProductNotfoundException : NotFoundException
    {
       public ProductNotfoundException(Guid Id) : base("Product",Id)
        {

        }

    }
}

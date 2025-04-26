namespace CatalogAPI.Exceptions
{
    public class ProductNotfoundException : Exception
    {
       public ProductNotfoundException() : base("Product not found!")
        {

        }

    }
}

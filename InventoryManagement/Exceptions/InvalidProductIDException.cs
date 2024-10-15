namespace InventoryManagement.Exceptions
{
    public class InvalidProductIDException : InventoryValidationException
    {
        public InvalidProductIDException() : base("Invalid product ID")
        {
        }
    }
}

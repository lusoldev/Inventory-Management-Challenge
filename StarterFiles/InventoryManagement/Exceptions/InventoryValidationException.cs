namespace InventoryManagement.Exceptions
{
    public class InventoryValidationException : Exception
    {
        public InventoryValidationException(string message) : base(message)
        {
        }
    }
}

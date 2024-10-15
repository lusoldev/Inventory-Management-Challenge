namespace InventoryManagement.Model
{
    public class Product
    {
        public int ID { get; set; }
        public required string Name { get; set; }
        public required double Price { get; set; }
    }
}

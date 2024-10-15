namespace InventoryManagement.Model
{
    public class ProductEntry
    {
        public int EntryNumber { get; set; }
        public DateTime Date { get; set; }
        public required int ProductID { get; set; }
        public required string ProductName { get; set; }
        public required double Price { get; set; }
        public int Quantity { get; set; }
        public double TotalValue { get; set; }
    }
}

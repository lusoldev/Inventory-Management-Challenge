using InventoryManagement;
using InventoryManagement.Exceptions;
using InventoryManagement.Model;

namespace InventoryManagementTests
{
    [TestClass]
    public class InventoryProcessorTest
    {
        #region Validate Tests

        #region Valid Cases

        [TestMethod]
        public void Validate_EmptyProductEntries_DoesNotThrowException()
        {
            List<ProductEntry> productEntries = new();

            InventoryProcessor processor = new(productEntries);
            processor.Validate();
        }

        [TestMethod]
        public void Validate_SingleProductEntry_DoesNotThrowException()
        {
            List<ProductEntry> productEntries = new()
            {
                new ProductEntry
                {
                    EntryNumber = 1,
                    Date = new DateTime(2024, 01, 01),
                    ProductID = 1,
                    ProductName = "Product 1",
                    Price = 10.0,
                    Quantity = 5,
                    TotalValue = 50.0
                }
            };

            InventoryProcessor processor = new(productEntries);
            processor.Validate();
        }

        [TestMethod]
        public void Validate_TwoProductEntries_DoesNotThrowException()
        {
            List<ProductEntry> productEntries = new()
            {
                new ProductEntry
                {
                    EntryNumber = 1,
                    Date = new DateTime(2024, 01, 01),
                    ProductID = 1,
                    ProductName = "Product 1",
                    Price = 10.0,
                    Quantity = 5,
                    TotalValue = 50.0
                },
                new ProductEntry
                {
                    EntryNumber = 2,
                    Date = new DateTime(2024, 01, 02),
                    ProductID = 2,
                    ProductName = "Product 2",
                    Price = 20.0,
                    Quantity = 2,
                    TotalValue = 40.0
                }
            };

            InventoryProcessor processor = new(productEntries);
            processor.Validate();
        }

        #endregion

        #region Invalid Cases

        [TestMethod]
        public void Validate_NonSequentialProductIDs_ThrowsInvalidProductIDException()
        {
            List<ProductEntry> productEntries = new()
            {
                new ProductEntry
                {
                    EntryNumber = 1,
                    Date = new DateTime(2024, 01, 01),
                    ProductID = 1,
                    ProductName = "Product 1",
                    Price = 10.0,
                    Quantity = 5,
                    TotalValue = 50.0
                },
                new ProductEntry
                {
                    EntryNumber = 2,
                    Date = new DateTime(2024, 01, 02),
                    ProductID = 3, // Skips ProductID 2
                    ProductName = "Product 3",
                    Price = 15.0,
                    Quantity = 3,
                    TotalValue = 45.0
                }
            };

            InventoryProcessor processor = new(productEntries);
            Assert.ThrowsException<InvalidProductIDException>(() => processor.Validate(), "Invalid product ID");
        }

        [TestMethod]
        public void Validate_ProductIDStartsFromZero_ThrowsInvalidProductIDException()
        {
            List<ProductEntry> productEntries = new()
            {
                new ProductEntry
                {
                    EntryNumber = 1,
                    Date = new DateTime(2024, 01, 01),
                    ProductID = 0,
                    ProductName = "Product 0",
                    Price = 5.0,
                    Quantity = 10,
                    TotalValue = 50.0
                }
            };

            InventoryProcessor processor = new(productEntries);
            Assert.ThrowsException<InvalidProductIDException>(() => processor.Validate(), "Invalid product ID");
        }

        #endregion

        #endregion

        #region TotalInventoryValue Tests

        [TestMethod]
        public void TotalInventoryValue_NoEntries_ReturnsZero()
        {
            List<ProductEntry> productEntries = new();

            InventoryProcessor processor = new(productEntries);
            processor.Validate();

            Assert.AreEqual(0, processor.TotalInventoryValue());
        }

        [TestMethod]
        public void TotalInventoryValue_SingleEntry_ReturnsCorrectValue()
        {
            List<ProductEntry> productEntries = new()
            {
                new ProductEntry
                {
                    EntryNumber = 1,
                    Date = new DateTime(2024, 01, 01),
                    ProductID = 1,
                    ProductName = "Product 1",
                    Price = 10.0,
                    Quantity = 5,
                    TotalValue = 50.0
                }
            };

            InventoryProcessor processor = new(productEntries);
            processor.Validate();

            Assert.AreEqual(50.0, processor.TotalInventoryValue());
        }

        [TestMethod]
        public void TotalInventoryValue_MultipleEntries_ReturnsSum()
        {
            List<ProductEntry> productEntries = new()
            {
                new ProductEntry
                {
                    EntryNumber = 1,
                    Date = new DateTime(2024, 01, 01),
                    ProductID = 1,
                    ProductName = "Product 1",
                    Price = 10.0,
                    Quantity = 5,
                    TotalValue = 50.0
                },
                new ProductEntry
                {
                    EntryNumber = 2,
                    Date = new DateTime(2024, 01, 02),
                    ProductID = 2,
                    ProductName = "Product 2",
                    Price = 20.0,
                    Quantity = 3,
                    TotalValue = 60.0
                }
            };

            InventoryProcessor processor = new(productEntries);
            processor.Validate();

            Assert.AreEqual(110.0, processor.TotalInventoryValue());
        }

        #endregion
    }
}

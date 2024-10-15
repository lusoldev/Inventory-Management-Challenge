using InventoryManagement.Exceptions;
using InventoryManagement.Model;

namespace InventoryManagement
{
    /// <summary>
    /// Represents a set of product entries.
    /// Provides methods to validate them and perform queries.
    /// </summary>
    public class InventoryProcessor
    {
        private readonly List<ProductEntry> productEntries;

        /// <summary>
        /// Initializes a new instance of the InventoryProcessor class.
        /// </summary>
        /// <param name="productEntries">List of product entries to be processed and validated.</param>
        public InventoryProcessor(List<ProductEntry> productEntries)
        {
            this.productEntries = productEntries;
        }

        #region Private Validations

        /// <summary>
        /// Validates that product IDs start from 1, are sequential, and have no gaps.
        /// </summary>
        /// <exception cref="InvalidProductIDException">
        /// Thrown when the product IDs are not sequential or have gaps.
        /// </exception>
        private void ValidateSequentialProductIDs()
        {
            for (int i = 1; i <= productEntries.Count; i++)
            {
                if (productEntries[i - 1].ProductID != i)
                {
                    throw new InvalidProductIDException();
                }
            }
        }

        #endregion

        /// <summary>
        /// Performs necessary validations on the product entries.
        /// </summary>
        /// <exception cref="InventoryValidationException">
        /// Thrown when any of the validations fail.
        /// </exception>
        public void Validate()
        {
            ValidateSequentialProductIDs();
            // TODO: ValidateChronologicalEntries
            // TODO: ValidateConsistentProductData
            // TODO: ValidateNonNegativeStockLevels
            // TODO: ValidateCorrectEntryValueCalculation
            // TODO: ValidateAccurateInventoryValue
            // TODO: ValidatePositivePricing
            // TODO: ValidatePositiveQuantity
            // TODO: ValidateAccurateTotalQuantity
        }

        /// <summary>
        /// Calculates the total value by summing the value of all products.
        /// </summary>
        /// <returns>The total inventory value.</returns>
        public double TotalInventoryValue()
        {
            double total = 0;
            foreach (var entry in productEntries)
            {
                total += entry.TotalValue;
            }
            return total;
        }

        /// <summary>
        /// Returns the ID of the product with the highest stock quantity.
        /// </summary>
        /// <returns>Product ID.</returns>
        public int ProductWithHighestStockQuantity()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the ID of the product that has the highest total value in stock.
        /// </summary>
        /// <returns>Product ID.</returns>
        public int ProductWithHighestTotalValue()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the name of the product that has been restocked the most times.
        /// </summary>
        /// <returns>Product name.</returns>
        public string MostFrequentlyRestockedProduct()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Calculates the total inventory value on a given date.
        /// </summary>
        /// <param name="date">Date for which to calculate the inventory value.</param>
        /// <returns>Total inventory value on the specified date.</returns>
        public double InventoryValueOnSpecificDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the ID of the supplier who provided the most units of a specific product.
        /// </summary>
        /// <param name="productID">Product ID.</param>
        /// <returns>Supplier ID.</returns>
        public int TopSupplierForProduct(int productID)
        {
            throw new NotImplementedException();
        }
    }
}

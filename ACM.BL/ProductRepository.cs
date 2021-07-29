using System;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);

            if (productId == 2)
            {
                product.ProductName = "Book";
                product.ProductDescription = "Interesting book";
                product.CurrentPrice = 15.96m;
            }
            Object myObject = new Object();
            return product;
        }
        /// <summary>
        /// Saves the current customer.
        /// </summary>
        /// <returns></returns>
        public bool Save(Product product)
        {
            var success = true;
            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        //Code to Insert new item
                    }
                    else
                    {
                        //Call to update existing value
                    }
                }
                else success = false;
            }
            return success;
        }


    }
}

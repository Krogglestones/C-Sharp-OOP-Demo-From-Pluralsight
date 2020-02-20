using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeCustomerManagement.BL
{
    public class ProductRepository
    {

        //  Retreive 1 product
        public Product Retreive(int productId)
        {
            Product product = new Product(productId);

            //  temp hardcoded items

            if (productId == 2)
            {
                product.ProductName = "Pie";
                product.Description = "A hobbit meal.";
                product.CurrentPrice = 4.25M;
            }
            return product;
        }

        public bool Save(Product product)
        {
            var success = true;

            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        /// call an insert stored procedure
                    }
                    else
                    {
                        ///  call an update stored procedure
                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }

    }
}

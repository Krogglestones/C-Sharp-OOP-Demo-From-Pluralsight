using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeCustomerManagement.BL
{
    public class Product
    {

        public Product()
        {

        }
        public Product(int productId)
        {
            ProductId = productId;
        } 

        public int ProductId { get; private set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal? CurrentPrice { get; set; }


        //retrieve 1 product
        public Product Retreive(int productId)
        {
            return new Product();
        }

        //  retreive all products

        public List<Product> Retreive()
        {
            return new List<Product>();
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }
    }
}

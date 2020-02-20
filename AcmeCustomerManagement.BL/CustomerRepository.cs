using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeCustomerManagement.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }

        public Customer Retreive(int customerId)
        {
            Customer customer = new Customer(customerId);

            if (customerId == 1)
            {
                // temp hardcoded instance
                customer.EmailAddress = "bbaggins@hotmail.com";
                customer.FirstName = "Bilbo";
                customer.LastName = "Baggins";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }
            return customer;
        }

        public bool Save(Customer customer)
        {
            var success = true;

            if (customer.HasChanges)
            {
                if (customer.IsValid)
                {
                    if (customer.IsNew)
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

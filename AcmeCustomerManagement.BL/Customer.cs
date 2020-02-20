using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeCustomerManagement.BL
{
    public class Customer
    {


         // constructors

            public Customer()
            {
                // empty contstructor
            }

        //since the customer ID is private, construct it here
        
            public Customer(int customerId)
            {
            CustomerId = customerId;
            }


        public int CustomerId { get; private set; }
        public string EmailAddress { get; set; }

        public string FirstName { get; set; }

        public string FullName
        {
            get
            {
                //  tests for empty 1st and last name seperately at the same time
                
                string fullname = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullname))
                    {
                        fullname += ", ";
                    }
                }   fullname += FirstName;
                return FullName;
            }
        }

        // static shares the count with all object instances
        public static int InstanceCount { get; set; }

        private string _lastName;

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

        public Customer Retrieve(int customerId)
        {
            return new Customer();
        }
        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        public bool Save()
        {
            return true;
        }
    }
}

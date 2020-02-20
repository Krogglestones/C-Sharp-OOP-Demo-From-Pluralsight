using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeCustomerManagement.BL
{
    public class AddressRepository
    {

        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);

            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Delving road";
                address.StreetLine2 = "Gamgee blvd";
                address.City = "Michel Delving";
                address.State = "Shire";
                address.Country = "Middle Earth";
                address.PostalCode = "02420";
            }

            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
            AddressType = 1,
            StreetLine1 = "Delving road",
            StreetLine2 = "Gamgee blvd",
            City = "Michel Delving",
            State = "Shire",
            Country = "Middle Earth",
            PostalCode = "02420"
        };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Hobbit road",
                StreetLine2 = "Bywater blvd",
                City = "Overhill",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "02422"
            };
            addressList.Add(address);

            return addressList;
        }

        public bool Save(Address address)
        {
            var success = true;

            if (address.HasChanges)
            {
                if (address.IsValid)
                {
                    if (address.IsNew)
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

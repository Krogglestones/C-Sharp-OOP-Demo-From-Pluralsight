using System;
using System.Collections.Generic;
using AcmeCustomerManagement.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AcmeCustomerManagement.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetreiveValid()
        {

            // Arrange

            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "bbaggins@hotmail.com",
                FirstName = "Bilbo",
                LastName = "Baggins",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        AddressType = 1,
                        StreetLine1 = "Delving road",
                        StreetLine2 = "Gamgee blvd",
                        City = "Michel Delving",
                        State = "Shire",
                        Country = "Middle Earth",
                        PostalCode = "02420"
                    },
                    new Address()
                    {
                        AddressType = 2,
                        StreetLine1 = "Hobbit road",
                        StreetLine2 = "Bywater blvd",
                        City = "Overhill",
                        State = "Shire",
                        Country = "Middle Earth",
                        PostalCode = "02422"
                    }
                }
            };

            //  Act

            var actual = customerRepository.Retreive(1);

            //  Assert

            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
                
            }

        }
    }
}

using System;
using AcmeCustomerManagement.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AcmeCustomerManagement.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            // Arrange
            Customer customer = new Customer
            {
                FirstName = "Frodo",
                LastName = "Baggins"
            };

            string expected = "Baggins, Frodo";

            // Act

            string actual = customer.FullName;

            // Assert

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            // Arrange

            Customer customer = new Customer
            {
                LastName = "Baggins"
            };
            string expected = "Baggins";

            // Act

            string actual = customer.FullName;

            // Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            //  Arrange
            var c1 = new Customer();
            c1.FirstName = "Bilbo";
            Customer.InstanceCount += 1;

            var c2 = new Customer();
            c2.FirstName = "Frodo";
            Customer.InstanceCount += 1;

            var c3 = new Customer();
            c3.FirstName = "Gandalf";
            Customer.InstanceCount += 1;

            //  Act


            // Assert

            Assert.AreEqual(3, Customer.InstanceCount);
        }


        [TestMethod]
        public void ValidateValid()
        {
            // Arrange

            var customer = new Customer
            {
                LastName = "Bilbo",
                EmailAddress = "bbaggins@theshire.com"
            };
            var expected = true;

            // Act

            var actual = customer.Validate();

            //Assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod] 
        public void ValidateMissingLastName()
        {
            //  Arrange

            var customer = new Customer
            {
                EmailAddress = "bbaggins@theshire.com"
            };
            var expected = false;

            //  Act

            var actual = customer.Validate();

            //  Assert

            Assert.AreEqual(expected, actual);
        }
    }
}

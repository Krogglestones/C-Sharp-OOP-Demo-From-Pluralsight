using System;
using AcmeCustomerManagement.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AcmeCustomerManagement.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetreiveTest()
        {
            //  Arrange

            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                CurrentPrice = 4.25M,
                Description = "A hobbit meal.",
                ProductName = "Pie"
            };

            //  Act

            var actual = productRepository.Retreive(2);

            //  Assert

            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.Description, actual.Description);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
        }

        [TestMethod]
        public void SaveTestValid()
        {
            //  Arrange

            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = 4.22M,
                Description = "Made from Shire apples.",
                ProductName = "Pie",
                HasChanges = true
            };

            //  Act

            var actual = productRepository.Save(updatedProduct);

            //  Assert

            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void SaveTestMissingPrice()
        {
            //  Arrange

            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = null,
                Description = "Made from Shire apples.",
                ProductName = "Pie",
                HasChanges = true
            };

            //  Act

            var actual = productRepository.Save(updatedProduct);

            //  Assert

            Assert.AreEqual(false, actual);

        }

    }
}

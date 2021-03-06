﻿using System;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            //  Arrange

            var source = "MeatBalls";
            var expected = "Meat Balls";

            //  Act

            var actual = source.InsertSpaces();

            //  Assert

            Assert.AreEqual(expected, actual);

        }
    }
}

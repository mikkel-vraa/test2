using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Auktionigen;

namespace Auktionigen
{
    [TestClass]
    public class CreateAutionMvcTest
    {
        [TestMethod]
        public void Auction()
        {
            // Arrange
            AuktionModel auction = new AuktionModel();

            // Act
            ViewResult result = auction.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}

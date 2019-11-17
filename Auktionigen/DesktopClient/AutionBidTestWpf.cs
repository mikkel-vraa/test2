using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesktopClient
{
    [TestClass]
    public class AutionBidTestWpf
    {
        [TestMethod]
        public void Auction()
        {
            // Arrange
            Auction auction = new Auction();

            // Act
            ViewResult result = auction.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesktopClient
{
    [TestClass]
    public class AutionBidTestMvc
    {
        [TestMethod]
        public void Auction()
        {
            // Arrange
            double expectedBid = 200;

            // Act
            double resultBid = Controller.CreateBid(bid);

            // Assert
            Assert.AreEqual(expectedBid, resultBid, 0.001);
        }
    }
}

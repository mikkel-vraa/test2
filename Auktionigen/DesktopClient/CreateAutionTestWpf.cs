using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesktopClient
{
    [TestClass]
    public class CreateAutionTestWpf
    {
        [TestMethod]
        public void Auction()
        {
            // Arrange
            Auction auction = new Auction();

            // Act
            Controller.CreateAuction;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}

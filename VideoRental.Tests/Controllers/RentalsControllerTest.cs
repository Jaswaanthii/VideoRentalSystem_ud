using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using VideoRental;
using VideoRental.Controllers;

namespace VideoRental.Tests.Controllers
{
    [TestClass]
    public class RentalsControllerTest
    {
        [TestMethod]
        public void Rentals()
        {
            // Arrange
           RentalsController controller = new RentalsController();

            // Act
            ViewResult result = controller.Rentals() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}

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
    public class CustomersControllerTest
    {
        [TestMethod]
        public void Customers()
        {
            // Arrange
            CustomersController controller = new CustomersController();

            // Act
            ViewResult result = controller.Customers() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}

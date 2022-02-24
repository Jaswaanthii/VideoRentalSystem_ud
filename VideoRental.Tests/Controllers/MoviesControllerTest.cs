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
    public class MoviesControllerTest
    {
        [TestMethod]
        public void Movies()
        {
            // Arrange
           MoviesController controller = new MoviesController();

            // Act
            ViewResult result = controller.Movies() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}

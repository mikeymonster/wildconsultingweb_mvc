using System.Web.Mvc;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WildConsulting.WebSite.Mvc.Controllers;

namespace WildConsulting.WebSite.Mvc.Tests
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void HomeController_Index_Should_Return_ViewResult()
        {
            var controller = new HomeController();

            var result = controller.Index();

            result.Should().NotBeNull();
            result.Should().BeOfType<ViewResult>();

            var viewResult = result as ViewResult;
            viewResult.Should().NotBeNull();
            viewResult?.ViewData.ModelState.IsValid.Should().BeTrue();
            viewResult?.ViewData.ModelState.Count.Should().Be(0);
        }

        [TestMethod]
        public void HomeController_About_Should_Return_ViewResult()
        {
            var controller = new HomeController();

            var result = controller.About();

            result.Should().NotBeNull();
            result.Should().BeOfType<ViewResult>();

            var viewResult = result as ViewResult;
            viewResult.Should().NotBeNull();
            viewResult?.ViewData.ModelState.IsValid.Should().BeTrue();
            viewResult?.ViewData.ModelState.Count.Should().Be(0);
        }

        [TestMethod]
        public void HomeController_Contact_Should_Return_ViewResult()
        {
            var controller = new HomeController();

            var result = controller.Contact();

            result.Should().NotBeNull();
            result.Should().BeOfType<ViewResult>();

            var viewResult = result as ViewResult;
            viewResult.Should().NotBeNull();
            viewResult?.ViewData.ModelState.IsValid.Should().BeTrue();
            viewResult?.ViewData.ModelState.Count.Should().Be(0);
        }
    }
}

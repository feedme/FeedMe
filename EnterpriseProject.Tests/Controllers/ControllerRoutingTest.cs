using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EnterpriseProject;
using EnterpriseProject.Controllers;
using Moq;

namespace EnterpriseProject.Tests.Controllers
{
    [TestClass]
    public class ControllerRoutingTest
    {
        [TestMethod]
        public void CanMapToAccounts_LogOn() {
            RouteCollection routes = new RouteCollection();
            MvcApplication.RegisterRoutes(routes);
            var httpContextMock = new Mock<HttpContextBase>();
            httpContextMock.Setup(c => c.Request
            .AppRelativeCurrentExecutionFilePath).Returns("~/Accounts/LogOn");
            //act
            RouteData routeData = routes.GetRouteData(httpContextMock.Object);
            //assert
            Assert.IsNotNull(routeData, "Should have found the route");
            Assert.AreEqual("Accounts", routeData.Values["Controller"]);
            Assert.AreEqual("LogOn", routeData.Values["action"]);
       }

        [TestMethod]
        public void CanMapToAccounts_LogOff() {
            RouteCollection routes = new RouteCollection();
            MvcApplication.RegisterRoutes(routes);
            var httpContextMock = new Mock<HttpContextBase>();
            httpContextMock.Setup(c => c.Request
            .AppRelativeCurrentExecutionFilePath).Returns("~/Accounts/LogOff");
            //act
            RouteData routeData = routes.GetRouteData(httpContextMock.Object);
            //assert
            Assert.IsNotNull(routeData, "Should have found the route");
            Assert.AreEqual("Accounts", routeData.Values["Controller"]);
            Assert.AreEqual("LogOff", routeData.Values["action"]);
       }

        [TestMethod]
        public void CanMapToAccounts_Register()
        {
            RouteCollection routes = new RouteCollection();
            MvcApplication.RegisterRoutes(routes);
            var httpContextMock = new Mock<HttpContextBase>();
            httpContextMock.Setup(c => c.Request
            .AppRelativeCurrentExecutionFilePath).Returns("~/Accounts/Register");
            //act
            RouteData routeData = routes.GetRouteData(httpContextMock.Object);
            //assert
            Assert.IsNotNull(routeData, "Should have found the route");
            Assert.AreEqual("Accounts", routeData.Values["Controller"]);
            Assert.AreEqual("Register", routeData.Values["action"]);
        }

        [TestMethod]
        public void CanMapToAccounts_ChangePassword()
        {
            RouteCollection routes = new RouteCollection();
            MvcApplication.RegisterRoutes(routes);
            var httpContextMock = new Mock<HttpContextBase>();
            httpContextMock.Setup(c => c.Request
            .AppRelativeCurrentExecutionFilePath).Returns("~/Accounts/ChangePassword");
            //act
            RouteData routeData = routes.GetRouteData(httpContextMock.Object);
            //assert
            Assert.IsNotNull(routeData, "Should have found the route");
            Assert.AreEqual("Accounts", routeData.Values["Controller"]);
            Assert.AreEqual("ChangePassword", routeData.Values["action"]);
        }

        [TestMethod]
        public void CanMapToAccounts_ChangePasswordSuccess()
        {
            RouteCollection routes = new RouteCollection();
            MvcApplication.RegisterRoutes(routes);
            var httpContextMock = new Mock<HttpContextBase>();
            httpContextMock.Setup(c => c.Request
            .AppRelativeCurrentExecutionFilePath).Returns("~/Accounts/ChangePasswordSuccess");
            //act
            RouteData routeData = routes.GetRouteData(httpContextMock.Object);
            //assert
            Assert.IsNotNull(routeData, "Should have found the route");
            Assert.AreEqual("Accounts", routeData.Values["Controller"]);
            Assert.AreEqual("ChangePasswordSuccess", routeData.Values["action"]);
        }

        [TestMethod]
        public void CanMapToFriends_Index()
        {
            RouteCollection routes = new RouteCollection();
            MvcApplication.RegisterRoutes(routes);
            var httpContextMock = new Mock<HttpContextBase>();
            httpContextMock.Setup(c => c.Request
            .AppRelativeCurrentExecutionFilePath).Returns("~/Friends/Index");
            //act
            RouteData routeData = routes.GetRouteData(httpContextMock.Object);
            //assert
            Assert.IsNotNull(routeData, "Should have found the route");
            Assert.AreEqual("Friends", routeData.Values["Controller"]);
            Assert.AreEqual("Index", routeData.Values["action"]);
        }

        [TestMethod]
        public void CanMapToFriends_Show()
        {
            RouteCollection routes = new RouteCollection();
            MvcApplication.RegisterRoutes(routes);
            var httpContextMock = new Mock<HttpContextBase>();
            httpContextMock.Setup(c => c.Request
            .AppRelativeCurrentExecutionFilePath).Returns("~/Friends/Show");
            //act
            RouteData routeData = routes.GetRouteData(httpContextMock.Object);
            //assert
            Assert.IsNotNull(routeData, "Should have found the route");
            Assert.AreEqual("Friends", routeData.Values["Controller"]);
            Assert.AreEqual("Show", routeData.Values["action"]);
        }

        [TestMethod]
        public void CanMapToHome_Index()
        {
            RouteCollection routes = new RouteCollection();
            MvcApplication.RegisterRoutes(routes);
            var httpContextMock = new Mock<HttpContextBase>();
            httpContextMock.Setup(c => c.Request
            .AppRelativeCurrentExecutionFilePath).Returns("~/Home/Index");
            //act
            RouteData routeData = routes.GetRouteData(httpContextMock.Object);
            //assert
            Assert.IsNotNull(routeData, "Should have found the route");
            Assert.AreEqual("Home", routeData.Values["Controller"]);
            Assert.AreEqual("Index", routeData.Values["action"]);
        }

        [TestMethod]
        public void CanMapToHome_About()
        {
            RouteCollection routes = new RouteCollection();
            MvcApplication.RegisterRoutes(routes);
            var httpContextMock = new Mock<HttpContextBase>();
            httpContextMock.Setup(c => c.Request
            .AppRelativeCurrentExecutionFilePath).Returns("~/Home/About");
            //act
            RouteData routeData = routes.GetRouteData(httpContextMock.Object);
            //assert
            Assert.IsNotNull(routeData, "Should have found the route");
            Assert.AreEqual("Home", routeData.Values["Controller"]);
            Assert.AreEqual("About", routeData.Values["action"]);
        }

        [TestMethod]
        public void CanMapToItems_Index()
        {
            RouteCollection routes = new RouteCollection();
            MvcApplication.RegisterRoutes(routes);
            var httpContextMock = new Mock<HttpContextBase>();
            httpContextMock.Setup(c => c.Request
            .AppRelativeCurrentExecutionFilePath).Returns("~/Items/Index");
            //act
            RouteData routeData = routes.GetRouteData(httpContextMock.Object);
            //assert
            Assert.IsNotNull(routeData, "Should have found the route");
            Assert.AreEqual("Items", routeData.Values["Controller"]);
            Assert.AreEqual("Index", routeData.Values["action"]);
        }

        [TestMethod]
        public void CanMapToItems_Details()
        {
            RouteCollection routes = new RouteCollection();
            MvcApplication.RegisterRoutes(routes);
            var httpContextMock = new Mock<HttpContextBase>();
            httpContextMock.Setup(c => c.Request
            .AppRelativeCurrentExecutionFilePath).Returns("~/Items/Details");
            //act
            RouteData routeData = routes.GetRouteData(httpContextMock.Object);
            //assert
            Assert.IsNotNull(routeData, "Should have found the route");
            Assert.AreEqual("Items", routeData.Values["Controller"]);
            Assert.AreEqual("Details", routeData.Values["action"]);
        }

        [TestMethod]
        public void CanMapToItems_ListMenus()
        {
            RouteCollection routes = new RouteCollection();
            MvcApplication.RegisterRoutes(routes);
            var httpContextMock = new Mock<HttpContextBase>();
            httpContextMock.Setup(c => c.Request
            .AppRelativeCurrentExecutionFilePath).Returns("~/Items/ListMenus");
            //act
            RouteData routeData = routes.GetRouteData(httpContextMock.Object);
            //assert
            Assert.IsNotNull(routeData, "Should have found the route");
            Assert.AreEqual("Items", routeData.Values["Controller"]);
            Assert.AreEqual("ListMenus", routeData.Values["action"]);
        }

        [TestMethod]
        public void CanMapToItems_Create()
        {
            RouteCollection routes = new RouteCollection();
            MvcApplication.RegisterRoutes(routes);
            var httpContextMock = new Mock<HttpContextBase>();
            httpContextMock.Setup(c => c.Request
            .AppRelativeCurrentExecutionFilePath).Returns("~/Items/Create");
            //act
            RouteData routeData = routes.GetRouteData(httpContextMock.Object);
            //assert
            Assert.IsNotNull(routeData, "Should have found the route");
            Assert.AreEqual("Items", routeData.Values["Controller"]);
            Assert.AreEqual("Create", routeData.Values["action"]);
        }

        [TestMethod]
        public void CanMapToItems_Edit()
        {
            RouteCollection routes = new RouteCollection();
            MvcApplication.RegisterRoutes(routes);
            var httpContextMock = new Mock<HttpContextBase>();
            httpContextMock.Setup(c => c.Request
            .AppRelativeCurrentExecutionFilePath).Returns("~/Items/Edit");
            //act
            RouteData routeData = routes.GetRouteData(httpContextMock.Object);
            //assert
            Assert.IsNotNull(routeData, "Should have found the route");
            Assert.AreEqual("Items", routeData.Values["Controller"]);
            Assert.AreEqual("Edit", routeData.Values["action"]);
        }

        [TestMethod]
        public void CanMapToItems_Delete()
        {
            RouteCollection routes = new RouteCollection();
            MvcApplication.RegisterRoutes(routes);
            var httpContextMock = new Mock<HttpContextBase>();
            httpContextMock.Setup(c => c.Request
            .AppRelativeCurrentExecutionFilePath).Returns("~/Items/Delete");
            //act
            RouteData routeData = routes.GetRouteData(httpContextMock.Object);
            //assert
            Assert.IsNotNull(routeData, "Should have found the route");
            Assert.AreEqual("Items", routeData.Values["Controller"]);
            Assert.AreEqual("Delete", routeData.Values["action"]);
        }

        [TestMethod]
        public void CanMapToMenus_Index()
        {
            RouteCollection routes = new RouteCollection();
            MvcApplication.RegisterRoutes(routes);
            var httpContextMock = new Mock<HttpContextBase>();
            httpContextMock.Setup(c => c.Request
            .AppRelativeCurrentExecutionFilePath).Returns("~/Menus/Index");
            //act
            RouteData routeData = routes.GetRouteData(httpContextMock.Object);
            //assert
            Assert.IsNotNull(routeData, "Should have found the route");
            Assert.AreEqual("Menus", routeData.Values["Controller"]);
            Assert.AreEqual("Index", routeData.Values["action"]);
        }

        [TestMethod]
        public void CanMapToMenus_List()
        {
            RouteCollection routes = new RouteCollection();
            MvcApplication.RegisterRoutes(routes);
            var httpContextMock = new Mock<HttpContextBase>();
            httpContextMock.Setup(c => c.Request
            .AppRelativeCurrentExecutionFilePath).Returns("~/Menus/List");
            //act
            RouteData routeData = routes.GetRouteData(httpContextMock.Object);
            //assert
            Assert.IsNotNull(routeData, "Should have found the route");
            Assert.AreEqual("Menus", routeData.Values["Controller"]);
            Assert.AreEqual("List", routeData.Values["action"]);
        }

        [TestMethod]
        public void CanMapToMenus_Show()
        {
            RouteCollection routes = new RouteCollection();
            MvcApplication.RegisterRoutes(routes);
            var httpContextMock = new Mock<HttpContextBase>();
            httpContextMock.Setup(c => c.Request
            .AppRelativeCurrentExecutionFilePath).Returns("~/Menus/Show");
            //act
            RouteData routeData = routes.GetRouteData(httpContextMock.Object);
            //assert
            Assert.IsNotNull(routeData, "Should have found the route");
            Assert.AreEqual("Menus", routeData.Values["Controller"]);
            Assert.AreEqual("Show", routeData.Values["action"]);
        }

        [TestMethod]
        public void CanMapToMenus_Details()
        {
            RouteCollection routes = new RouteCollection();
            MvcApplication.RegisterRoutes(routes);
            var httpContextMock = new Mock<HttpContextBase>();
            httpContextMock.Setup(c => c.Request
            .AppRelativeCurrentExecutionFilePath).Returns("~/Menus/Details");
            //act
            RouteData routeData = routes.GetRouteData(httpContextMock.Object);
            //assert
            Assert.IsNotNull(routeData, "Should have found the route");
            Assert.AreEqual("Menus", routeData.Values["Controller"]);
            Assert.AreEqual("Details", routeData.Values["action"]);
        }

        [TestMethod]
        public void CanMapToMenus_Create()
        {
            RouteCollection routes = new RouteCollection();
            MvcApplication.RegisterRoutes(routes);
            var httpContextMock = new Mock<HttpContextBase>();
            httpContextMock.Setup(c => c.Request
            .AppRelativeCurrentExecutionFilePath).Returns("~/Menus/Create");
            //act
            RouteData routeData = routes.GetRouteData(httpContextMock.Object);
            //assert
            Assert.IsNotNull(routeData, "Should have found the route");
            Assert.AreEqual("Menus", routeData.Values["Controller"]);
            Assert.AreEqual("Create", routeData.Values["action"]);
        }

        [TestMethod]
        public void CanMapToMenus_Edit()
        {
            RouteCollection routes = new RouteCollection();
            MvcApplication.RegisterRoutes(routes);
            var httpContextMock = new Mock<HttpContextBase>();
            httpContextMock.Setup(c => c.Request
            .AppRelativeCurrentExecutionFilePath).Returns("~/Menus/Edit");
            //act
            RouteData routeData = routes.GetRouteData(httpContextMock.Object);
            //assert
            Assert.IsNotNull(routeData, "Should have found the route");
            Assert.AreEqual("Menus", routeData.Values["Controller"]);
            Assert.AreEqual("Edit", routeData.Values["action"]);
        }


        [TestMethod]
        public void CanMapToMenus_AddItems()
        {
            RouteCollection routes = new RouteCollection();
            MvcApplication.RegisterRoutes(routes);
            var httpContextMock = new Mock<HttpContextBase>();
            httpContextMock.Setup(c => c.Request
            .AppRelativeCurrentExecutionFilePath).Returns("~/Menus/AddItems");
            //act
            RouteData routeData = routes.GetRouteData(httpContextMock.Object);
            //assert
            Assert.IsNotNull(routeData, "Should have found the route");
            Assert.AreEqual("Menus", routeData.Values["Controller"]);
            Assert.AreEqual("AddItems", routeData.Values["action"]);
        }

        [TestMethod]
        public void CanMapToMenus_Delete()
        {
            RouteCollection routes = new RouteCollection();
            MvcApplication.RegisterRoutes(routes);
            var httpContextMock = new Mock<HttpContextBase>();
            httpContextMock.Setup(c => c.Request
            .AppRelativeCurrentExecutionFilePath).Returns("~/Menus/Delete");
            //act
            RouteData routeData = routes.GetRouteData(httpContextMock.Object);
            //assert
            Assert.IsNotNull(routeData, "Should have found the route");
            Assert.AreEqual("Menus", routeData.Values["Controller"]);
            Assert.AreEqual("Delete", routeData.Values["action"]);
        }

        [TestMethod]
        public void CanMapToOrders_Index()
        {
            RouteCollection routes = new RouteCollection();
            MvcApplication.RegisterRoutes(routes);
            var httpContextMock = new Mock<HttpContextBase>();
            httpContextMock.Setup(c => c.Request
            .AppRelativeCurrentExecutionFilePath).Returns("~/Orders/Index");
            //act
            RouteData routeData = routes.GetRouteData(httpContextMock.Object);
            //assert
            Assert.IsNotNull(routeData, "Should have found the route");
            Assert.AreEqual("Orders", routeData.Values["Controller"]);
            Assert.AreEqual("Index", routeData.Values["action"]);
        }

        [TestMethod]
        public void CanMapToOrders_Details()
        {
            RouteCollection routes = new RouteCollection();
            MvcApplication.RegisterRoutes(routes);
            var httpContextMock = new Mock<HttpContextBase>();
            httpContextMock.Setup(c => c.Request
            .AppRelativeCurrentExecutionFilePath).Returns("~/Orders/Details");
            //act
            RouteData routeData = routes.GetRouteData(httpContextMock.Object);
            //assert
            Assert.IsNotNull(routeData, "Should have found the route");
            Assert.AreEqual("Orders", routeData.Values["Controller"]);
            Assert.AreEqual("Details", routeData.Values["action"]);
        }

        [TestMethod]
        public void CanMapToOrders_AddItemToOrder()
        {
            RouteCollection routes = new RouteCollection();
            MvcApplication.RegisterRoutes(routes);
            var httpContextMock = new Mock<HttpContextBase>();
            httpContextMock.Setup(c => c.Request
            .AppRelativeCurrentExecutionFilePath).Returns("~/Orders/AddItemToOrder");
            //act
            RouteData routeData = routes.GetRouteData(httpContextMock.Object);
            //assert
            Assert.IsNotNull(routeData, "Should have found the route");
            Assert.AreEqual("Orders", routeData.Values["Controller"]);
            Assert.AreEqual("AddItemToOrder", routeData.Values["action"]);
        }

        [TestMethod]
        public void CanMapToOrders_Create()
        {
            RouteCollection routes = new RouteCollection();
            MvcApplication.RegisterRoutes(routes);
            var httpContextMock = new Mock<HttpContextBase>();
            httpContextMock.Setup(c => c.Request
            .AppRelativeCurrentExecutionFilePath).Returns("~/Orders/Create");
            //act
            RouteData routeData = routes.GetRouteData(httpContextMock.Object);
            //assert
            Assert.IsNotNull(routeData, "Should have found the route");
            Assert.AreEqual("Orders", routeData.Values["Controller"]);
            Assert.AreEqual("Create", routeData.Values["action"]);
        }

        [TestMethod]
        public void CanMapToOrders_Delete()
        {
            RouteCollection routes = new RouteCollection();
            MvcApplication.RegisterRoutes(routes);
            var httpContextMock = new Mock<HttpContextBase>();
            httpContextMock.Setup(c => c.Request
            .AppRelativeCurrentExecutionFilePath).Returns("~/Orders/Delete");
            //act
            RouteData routeData = routes.GetRouteData(httpContextMock.Object);
            //assert
            Assert.IsNotNull(routeData, "Should have found the route");
            Assert.AreEqual("Orders", routeData.Values["Controller"]);
            Assert.AreEqual("Delete", routeData.Values["action"]);
        }

        [TestMethod]
        public void CanMapToProfile_Index()
        {
            RouteCollection routes = new RouteCollection();
            MvcApplication.RegisterRoutes(routes);
            var httpContextMock = new Mock<HttpContextBase>();
            httpContextMock.Setup(c => c.Request
            .AppRelativeCurrentExecutionFilePath).Returns("~/Profile/Index");
            //act
            RouteData routeData = routes.GetRouteData(httpContextMock.Object);
            //assert
            Assert.IsNotNull(routeData, "Should have found the route");
            Assert.AreEqual("Profile", routeData.Values["Controller"]);
            Assert.AreEqual("Index", routeData.Values["action"]);
        }

        [TestMethod]
        public void CanMapToProfile_Details()
        {
            RouteCollection routes = new RouteCollection();
            MvcApplication.RegisterRoutes(routes);
            var httpContextMock = new Mock<HttpContextBase>();
            httpContextMock.Setup(c => c.Request
            .AppRelativeCurrentExecutionFilePath).Returns("~/Profile/Details");
            //act
            RouteData routeData = routes.GetRouteData(httpContextMock.Object);
            //assert
            Assert.IsNotNull(routeData, "Should have found the route");
            Assert.AreEqual("Profile", routeData.Values["Controller"]);
            Assert.AreEqual("Details", routeData.Values["action"]);
        }

        [TestMethod]
        public void CanMapToProfile_Create()
        {
            RouteCollection routes = new RouteCollection();
            MvcApplication.RegisterRoutes(routes);
            var httpContextMock = new Mock<HttpContextBase>();
            httpContextMock.Setup(c => c.Request
            .AppRelativeCurrentExecutionFilePath).Returns("~/Profile/Create");
            //act
            RouteData routeData = routes.GetRouteData(httpContextMock.Object);
            //assert
            Assert.IsNotNull(routeData, "Should have found the route");
            Assert.AreEqual("Profile", routeData.Values["Controller"]);
            Assert.AreEqual("Create", routeData.Values["action"]);
        }

        [TestMethod]
        public void CanMapToProfile_Edit()
        {
            RouteCollection routes = new RouteCollection();
            MvcApplication.RegisterRoutes(routes);
            var httpContextMock = new Mock<HttpContextBase>();
            httpContextMock.Setup(c => c.Request
            .AppRelativeCurrentExecutionFilePath).Returns("~/Profile/Edit");
            //act
            RouteData routeData = routes.GetRouteData(httpContextMock.Object);
            //assert
            Assert.IsNotNull(routeData, "Should have found the route");
            Assert.AreEqual("Profile", routeData.Values["Controller"]);
            Assert.AreEqual("Edit", routeData.Values["action"]);
        }

        [TestMethod]
        public void CanMapToProfile_Delete()
        {
            RouteCollection routes = new RouteCollection();
            MvcApplication.RegisterRoutes(routes);
            var httpContextMock = new Mock<HttpContextBase>();
            httpContextMock.Setup(c => c.Request
            .AppRelativeCurrentExecutionFilePath).Returns("~/Profile/Delete");
            //act
            RouteData routeData = routes.GetRouteData(httpContextMock.Object);
            //assert
            Assert.IsNotNull(routeData, "Should have found the route");
            Assert.AreEqual("Profile", routeData.Values["Controller"]);
            Assert.AreEqual("Delete", routeData.Values["action"]);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EnterpriseProject.Models;
using System.Security;
using System.Web.Profile;
using System.Web.Security;

namespace EnterpriseProject.Controllers
{
    public class VendorsController : Controller
    {
        //
        // GET: /Vendors/
        FeedMeEntities db = new FeedMeEntities();
        MenusRepository menusRepository = new MenusRepository();
        VendorsRepository vendorsRepository = new VendorsRepository();
        ItemsRepository itemsRepository = new ItemsRepository();
        MenuItemsRepository menuitemsRepository = new MenuItemsRepository();
        OrdersRepository ordersRepository = new OrdersRepository();
        OrdersItemsRepository orderitemsRepository = new OrdersItemsRepository();

        [Authorize(Roles = "Customer")]
        public ActionResult Index()
        {
            MembershipUser user = Membership.GetUser();
            var vendors = vendorsRepository.FindAllVendors();
            return View(vendors);
        }

        [Authorize(Roles = "Vendor")]
        public ActionResult Orders()
        {
            MembershipUser user = Membership.GetUser();
            Vendor vendor = vendorsRepository.GetVendorByUserId((Guid)user.ProviderUserKey);
            var orders = ordersRepository.GetOrdersByVendorId(vendor.VendorId);
            orders = orders.Where(i=>i.Status == "submitted");
            return View(orders);
        }

        [Authorize(Roles = "Vendor")]
        public ActionResult ReceivedOrders()
        {
            MembershipUser user = Membership.GetUser();
            Vendor vendor = vendorsRepository.GetVendorByUserId((Guid)user.ProviderUserKey);
            var orders = ordersRepository.GetOrdersByVendorId(vendor.VendorId);
            orders = orders.Where(i => i.Status == "received");
            return View(orders);
        }

        [Authorize(Roles = "Vendor")]
        public ActionResult OrderDetails(Guid id)
        {
            var orderitems = orderitemsRepository.GetOrderItemsByOrderId(id);
            decimal subtotal = 0.00M;

            foreach (var item in orderitems)
            {
                subtotal += item.Item.Price * item.Quantity;
            }

            ViewData["user"] = orderitems.First().Order.aspnet_Users.UserName;
            ViewData["subtotal"] = subtotal;
            ViewData["orderid"] = id;
            ViewData["orderstatus"] = orderitems.First().Order.Status;
            return View(orderitems);
        }

        [HttpPost]
        [Authorize(Roles = "Vendor")]
        public ActionResult UpdateOrder(Guid id,string status)
        {
            var order = ordersRepository.GetOrder(id);
            order.Status = status;

            if (TryUpdateModel(order))
            {
                ordersRepository.save();
                return RedirectToAction("Orders");
            }

            return RedirectToAction("Orders");
        }
        //
        // GET: /Vendors/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Vendors/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Vendors/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Vendors/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Vendors/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Vendors/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Vendors/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

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
    public class OrdersController : Controller
    {
        MenusRepository menusRepository = new MenusRepository();
        VendorsRepository vendorsRepository = new VendorsRepository();
        ItemsRepository itemsRepository = new ItemsRepository();
        OrdersRepository ordersRepository = new OrdersRepository();
        OrdersItemsRepository orderitemsRepository = new OrdersItemsRepository();

        [Authorize(Roles = "Customer")]
        public ActionResult Index()
        {
            MembershipUser user = Membership.GetUser();
            var orders = ordersRepository.GetOrdersByUserId((Guid)user.ProviderUserKey);
            return View(orders);
        }

        public PartialViewResult Summary()
        {
            MembershipUser user = Membership.GetUser();
            var new_orders = ordersRepository.GetOrdersByStatusAndUserId("new", (Guid)user.ProviderUserKey);
            var submitted_orders = ordersRepository.GetOrdersByStatusAndUserId("submitted", (Guid)user.ProviderUserKey);
            decimal subtotal = 0.00M;
            ViewData["size"] = 0;
            ViewData["submitted_size"] = 0;

            if (new_orders.Count() > 0)
            {
                var summary_items = new_orders.First().OrderItems;

                if (summary_items.Count > 0)
                {
                    foreach (var item in summary_items)
                    {
                        subtotal += item.Item.Price * item.Quantity;
                    }
                }

                if (summary_items.Count > 0)
                {
                    ViewData["size"] = summary_items.Count;
                }
                else
                {
                    ViewData["size"] = 0;
                }
            }

            if (submitted_orders.Count() > 0)
            {
                    ViewData["submitted_size"] = submitted_orders.Count();
                
            }
            ViewData["subtotal"] = subtotal;

            return PartialView();
        }

        public PartialViewResult VendorSummary()
        {
            MembershipUser user = Membership.GetUser();
            Vendor vendor = vendorsRepository.GetVendorByUserId((Guid)user.ProviderUserKey);
            var orders = ordersRepository.GetOrdersByVendorId(vendor.VendorId);
            var new_orders = orders.Where(i => i.Status == "submitted");
            var received_orders = orders.Where(i => i.Status == "received");

            ViewData["new_orders_size"] = new_orders.Count();
            ViewData["received_orders_size"] = received_orders.Count();

            return PartialView();
        }
        //
        // GET: /Orders/Details/5

        public ActionResult Details(Guid id)
        {
            var orderitems = orderitemsRepository.GetOrderItemsByOrderId(id);
            decimal subtotal = 0.00M;

            foreach (var item in orderitems)
            {
                subtotal += item.Item.Price * item.Quantity;
            }

            ViewData["subtotal"] = subtotal;
            ViewData["orderid"] = id;
            ViewData["orderstatus"] = orderitems.First().Order.Status;
            return View(orderitems);
        }

        [HttpPost]
        [Authorize(Roles = "Customer")]
        public ActionResult AddItemToOrder(System.Guid itemId,System.Guid menuId,FormCollection collection)
        {
            
            MembershipUser user = Membership.GetUser();
            var orders = ordersRepository.GetOrdersByStatusAndUserId("new",(Guid)user.ProviderUserKey);
            var vendor = itemsRepository.GetVendorByItemId(itemId);
            OrderItem orderitem = new OrderItem();

            if (orders.Count() < 1)
            {
                Order order = new Order();
                order.OrderId = System.Guid.NewGuid();
                order.VendorId = vendor.VendorId;
                order.UserId = (Guid)user.ProviderUserKey;
                order.Status = "new";
                ordersRepository.add(order);
                ordersRepository.save();

                orderitem.OrderItemId = System.Guid.NewGuid();
                orderitem.ItemId = itemId;
                orderitem.OrderId = order.OrderId;
                orderitem.Quantity = Convert.ToInt32(collection[0]);
            }
            else
            {
                orderitem.OrderItemId = System.Guid.NewGuid();
                orderitem.ItemId = itemId;
                orderitem.OrderId = orders.First().OrderId;
                orderitem.Quantity = Convert.ToInt32(collection[0]);
            }

            if (TryUpdateModel(orderitem))
            {
                orderitemsRepository.add(orderitem); 
                orderitemsRepository.save();
                return RedirectToAction("Show","Menus",new { id=menuId });
            }
            


            return RedirectToAction("Index");
        }

        //
        // GET: /Orders/Create
        [HttpPost]
        [Authorize(Roles = "Customer")]
        public ActionResult PlaceOrder(Guid id)
        {
            MembershipUser user = Membership.GetUser();
            var orders = ordersRepository.GetOrdersByStatusAndUserId("new", (Guid)user.ProviderUserKey);
            Order updateorder = orders.First();
            updateorder.Status = "submitted";

            if (TryUpdateModel(updateorder))
            {
                ordersRepository.save();
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Orders/Create

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

        [Authorize(Roles = "Customer")]
        public ActionResult ChangeQuantity(System.Guid id)
        {
            OrderItem item = orderitemsRepository.GetOrderItem(id);
            return View(item);
        }

        //
        // POST: /Menus/Edit/5

        [HttpPost]
        [Authorize(Roles = "Customer")]
        public ActionResult ChangeQuantity(System.Guid id, FormCollection collection)
        {
            OrderItem item = orderitemsRepository.GetOrderItem(id);
            if (TryUpdateModel(item))
            {
                orderitemsRepository.save();
                return RedirectToAction("Index");
            }
            return View(item);
        }

        //
        // GET: /Orders/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Orders/Delete/5

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

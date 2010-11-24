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

        [Authorize(Roles = "Customer")]
        public ActionResult Index()
        {
            MembershipUser user = Membership.GetUser();
            var vendors = vendorsRepository.FindAllVendors();
            return View(vendors);
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

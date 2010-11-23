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
    public class MenuViewModel
    {
        public MenuViewModel(List<Menu> menus, List<Item> items)
        {
            this.Menus = menus;
            this.Items = items;
        }

        public List<Menu> Menus { get; private set; }
        public List<Item> Items { get; private set; }

    }

    public class ItemsController : Controller
    {
        MenusRepository menusRepository = new MenusRepository();
        VendorsRepository vendorsRepository = new VendorsRepository();
        ItemsRepository itemsRepository = new ItemsRepository();
        //
        // GET: /Items/

        public ActionResult Index()
        {
            MembershipUser user = Membership.GetUser();
            Vendor vendor = vendorsRepository.GetVendorByUserId((Guid)user.ProviderUserKey);
            var items = itemsRepository.GetItemsByVendorId(vendor.VendorId);
            return View(items);
        }

        public ActionResult AddToMenu(System.Guid itemid, System.Guid menuid)
        {
            itemsRepository.addtomenu(itemid, menuid);

            return View("Index");
        }

        //
        // GET: /Items/Details/5

        public ActionResult Details(System.Guid id)
        {
            MembershipUser user = Membership.GetUser();
            Vendor vendor = vendorsRepository.GetVendorByUserId((Guid)user.ProviderUserKey);
            var menus = menusRepository.GetMenusByVendorId(vendor.VendorId);
            Item item = itemsRepository.GetItem(id);

            ViewData["menus"] = menus;
            //ViewData.Model = menus.ToList();

            return View(item);
        }

        public ActionResult ListMenus()
        {
            MembershipUser user = Membership.GetUser();
            Vendor vendor = vendorsRepository.GetVendorByUserId((Guid)user.ProviderUserKey);
            var menus = menusRepository.GetMenusByVendorId(vendor.VendorId);

            return View(menus);
        }


        //
        // GET: /Items/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Items/Create

        [HttpPost]
        [Authorize(Roles = "Vendor")]
        public ActionResult Create(FormCollection collection)
        {
            Item item = new Item();
            MembershipUser user = Membership.GetUser();
            Vendor vendor = vendorsRepository.GetVendorByUserId((Guid)user.ProviderUserKey);
            item.VendorId = vendor.VendorId;
            item.ItemId = System.Guid.NewGuid();

            if (TryUpdateModel(item))
            {
                itemsRepository.add(item);
                itemsRepository.save();
                return View();
            }


            return View();
        }
        
        //
        // GET: /Items/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Items/Edit/5

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
        // GET: /Items/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Items/Delete/5

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

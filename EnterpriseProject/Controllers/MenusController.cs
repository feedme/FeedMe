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
    public class MenusController : Controller
    {
        MenusRepository menusRepository = new MenusRepository();
        VendorsRepository vendorsRepository = new VendorsRepository();
        ItemsRepository itemsRepository = new ItemsRepository();
        MenuItemsRepository menuitemsRepository = new MenuItemsRepository();
        //
        // GET: /Menus/

        [Authorize(Roles = "Vendor")]
        public ActionResult Index()
        {
            MembershipUser user = Membership.GetUser();
            Vendor vendor = vendorsRepository.GetVendorByUserId((Guid)user.ProviderUserKey);
            ViewData["vendorname"] = vendor.aspnet_Users.UserName;
            var menus = menusRepository.GetMenusByVendorId(vendor.VendorId);
            return View(menus);
        }

        [Authorize(Roles = "Customer")]
        public ActionResult List(Guid id)
        {
            Vendor vendor = vendorsRepository.GetVendor(id);
            ViewData["vendorname"] = vendor.aspnet_Users.UserName;
            var menus = menusRepository.GetMenusByVendorId(id);
            return View(menus);
        }

        //
        // GET: /Menus/Details/5

        public ActionResult Show(Guid id)
        {
            ViewData["menutitle"] = menusRepository.GetMenu(id).Description;
            var menuitems = menuitemsRepository.FindAllMenuItems(id);
            return View(menuitems);
        }

        public ActionResult Details(Guid id)
        {
            ViewData["menutitle"] = menusRepository.GetMenu(id).Description;
            var menuitems = menuitemsRepository.FindAllMenuItems(id);
            return View(menuitems);
        }

        //
        // GET: /Menus/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Menus/Create

        [HttpPost]
        [Authorize(Roles = "Vendor")]
        public ActionResult Create(FormCollection collection)
        {
            Menu menu = new Menu();
            MembershipUser user = Membership.GetUser();
            Vendor vendor = vendorsRepository.GetVendorByUserId((Guid)user.ProviderUserKey);
            menu.VendorId = vendor.VendorId;
            menu.MenuId = System.Guid.NewGuid();


            if (TryUpdateModel(menu))
            {
                menusRepository.add(menu);
                menusRepository.save();
                return RedirectToAction("index");
            }
            

            return RedirectToAction("Index");
        }
        
        //
        // GET: /Menus/Edit/5

        public ActionResult Edit(System.Guid id)
        {
            Menu menu = menusRepository.GetMenu(id);
            return View(menu);
        }

        //
        // POST: /Menus/Edit/5

        [HttpPost]
        [Authorize(Roles = "Vendor")]
        public ActionResult Edit(System.Guid id, FormCollection collection)
        {
            Menu menu = menusRepository.GetMenu(id);
            if (TryUpdateModel(menu))
            {
                menusRepository.save();
                return RedirectToAction("Index");
            }
            return View(menu);
        }

        [Authorize(Roles = "Vendor")]
        public ActionResult AddItems(System.Guid id)
        {
            Menu menu = menusRepository.GetMenu(id);
            ViewData["menuid"] = menu.MenuId;
            ViewData["menutitle"] = menu.Description;
            MembershipUser user = Membership.GetUser();
            Vendor vendor = vendorsRepository.GetVendorByUserId((Guid)user.ProviderUserKey);
            var items = itemsRepository.GetItemsByVendorId(vendor.VendorId);
            return View(items);
        }

        [HttpPost]
        [Authorize(Roles = "Vendor")]
        public ActionResult AddItems(System.Guid menuId, System.Guid itemId)
        {
            MenuItem menuitem = new MenuItem();
            menuitem.MenuId = menuId;
            menuitem.ItemId = itemId;
            menuitem.MenuItemId = System.Guid.NewGuid();

            //if (menuitemsRepository.GetMenuItem(itemId).Equals(null))
            //{
                if (TryUpdateModel(menuitem))
                {
                    menuitemsRepository.add(menuitem);
                    menuitemsRepository.save();
                    return RedirectToAction("index");
                }
            //}


            return RedirectToAction("Index");
        }
        //
        // GET: /Menus/Delete/5

        public ActionResult Delete(System.Guid id)
        {
            Menu menu = menusRepository.GetMenu(id);
            if (menu == null)
                return RedirectToAction("Index");
            else
                return View(menu);
        }

        //
        // POST: /NewsExtra/Delete/5

        [HttpPost]
        public ActionResult Delete(System.Guid id, FormCollection collection)
        {
            Menu menu = menusRepository.GetMenu(id);
            if (menu != null)
            {
                menusRepository.delete(menu);
                menusRepository.save();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult DeleteFromMenu(System.Guid menuid, System.Guid itemid)
        {
            MenuItem menuitem = menuitemsRepository.GetMenuItem(itemid);
            if (menuitem != null)
            {
                menuitemsRepository.delete(menuitem);
                menuitemsRepository.save();
            }
            return RedirectToAction("Index");
        }
    }
}

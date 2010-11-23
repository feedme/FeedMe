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
        //
        // GET: /Menus/

        public ActionResult Index()
        {
            MembershipUser user = Membership.GetUser();
            Vendor vendor = vendorsRepository.GetVendorByUserId((Guid)user.ProviderUserKey);
            var menus = menusRepository.GetMenusByVendorId(vendor.VendorId);
            return View(menus);
        }

        //
        // GET: /Menus/Details/5

        public ActionResult Details(int id)
        {
            return View();
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
    }
}

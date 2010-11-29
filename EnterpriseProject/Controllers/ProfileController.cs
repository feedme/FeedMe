using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Profile;
using System.Web.Security;
using System.Web.Mvc;
using EnterpriseProject.Models;

namespace EnterpriseProject.Controllers
{
    public class ProfileController : Controller
    {
        MembershipUser user = Membership.GetUser();
        ProfileCommon profile = new ProfileCommon();
        //
        // GET: /Profile/

        public ActionResult Index()
        {
            profile = profile.GetProfile(user.UserName);
            return View(profile);
        }

        //
        // GET: /Profile/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Profile/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Profile/Create

        [AcceptVerbs("POST")]
        public ActionResult Create(string firstname, string lastname, string preferences, string phone, string address, string city, string county)
        {
            ProfileCommon profile = ProfileCommon.Create(user.UserName, user.IsApproved) as ProfileCommon;

            profile.FirstName = firstname;
            profile.LastName = lastname;
            profile.Preferences = preferences;
            profile.Phone = phone;
            profile.Address = address;
            profile.City = city;
            profile.County = county;
            profile.Save();

            return RedirectToAction("Index");
        }
        
        //
        // GET: /Profile/Edit/5
 
        public ActionResult Edit()
        {
            profile = profile.GetProfile(user.UserName);
            return View(profile);
        }

        //
        // POST: /Profile/Edit/5

        [HttpPost]
        public ActionResult Edit(string firstname, string lastname, string preferences, string phone, string address, string city, string county)
        {
            profile = profile.GetProfile(user.UserName);

            profile.FirstName = firstname;
            profile.LastName = lastname;
            profile.Preferences = preferences;
            profile.Phone = phone;
            profile.Address = address;
            profile.City = city;
            profile.County = county;
            profile.Save();

            return RedirectToAction("Index");
        }

        //
        // GET: /Profile/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Profile/Delete/5

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

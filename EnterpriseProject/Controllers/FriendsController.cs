using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Security;
using System.Web.Profile;
using System.Web.Security;
using EnterpriseProject.Models;

namespace EnterpriseProject.Controllers
{
    public class FriendsController : Controller
    {
        //
        // GET: /Friends/
        // Retrieve a list of all users friends
        public ActionResult Index()
        {
            MembershipUserCollection allUsers = Membership.GetAllUsers();
            return View(allUsers);
        }

        // List all users that are not friends
        public ActionResult Find()
        {
            return View();
        }

        //Add a friendship
        [HttpPost]
        public ActionResult Add(Guid UserId)
        {
            return View();
        }

        //Destroy friendship
        [HttpPost]
        public ActionResult Destroy(Guid UserId)
        {
            return View();
        }

    }
}

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
        FriendshipRepository friendshipRepo = new FriendshipRepository();
        MembershipUser currentUser = Membership.GetUser();
        //
        // GET: /Friends/
        // Retrieve a list of all users friends
        public ActionResult Index()
        {
            MembershipUserCollection allUsers = Membership.GetAllUsers();
            var friendList = friendshipRepo.ListAllFriendships((Guid)currentUser.ProviderUserKey);
            foreach(var friend in friendList) {
                MembershipUser theFriend = Membership.GetUser(friend.FriendId);
                allUsers.Remove(theFriend.UserName);
            }
            allUsers.Remove(currentUser.UserName);
            return View(allUsers);
        }

        public ActionResult Show()
        {
            MembershipUserCollection friendsList = new MembershipUserCollection();

            var friends = friendshipRepo.ListAllFriendships((Guid)currentUser.ProviderUserKey);
            foreach (var f in friends)
            {
                MembershipUser theFriend = Membership.GetUser(f.FriendId);
                friendsList.Add(theFriend);
            }
            return View(friendsList);
        }

        //Add a friendship
        public ActionResult Add(Guid UserId)
        {
            Friendship f = new Friendship();
            f.UserId = (Guid)currentUser.ProviderUserKey;
            f.FriendId = UserId;
            f.FriendshipId = System.Guid.NewGuid();
            friendshipRepo.Add(f);
            friendshipRepo.Save();
            return RedirectToAction("Index");
        }

        //Destroy friendship
        public ActionResult Destroy(Guid UserId)
        {
            return View();
        }

    }
}

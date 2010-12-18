using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnterpriseProject.Models
{
    public class FriendshipRepository
    {
        FeedMeEntities entities = new FeedMeEntities();

        public IQueryable<Friendship> ListAllFriendships(Guid UserId)
        {
            return entities.Friendships.Where(i => i.UserId == UserId);
        }

        public void Add(Friendship f)
        {
            entities.Friendships.AddObject(f);
        }

        public Friendship GetFriendship(Guid FriendshipId)
        {
            return entities.Friendships.FirstOrDefault(i => i.FriendshipId == FriendshipId);
        }

        public void Save()
        {
            entities.SaveChanges();
        }
    }
}
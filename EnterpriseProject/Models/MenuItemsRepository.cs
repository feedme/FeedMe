using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnterpriseProject.Models
{
    public class MenuItemsRepository
    {
        FeedMeEntities entities = new FeedMeEntities();

        public IQueryable<MenuItem> FindAllItems()
        {
            return entities.MenuItems;
        }

        public MenuItem GetMenuItem(System.Guid guid)
        {
            return entities.MenuItems.FirstOrDefault(i => i.ItemId == guid);
        }

        public IQueryable<MenuItem> FindAllMenuItems(System.Guid guid)
        {
            return entities.MenuItems.Where(i => i.MenuId == guid);
        }

        public void add(MenuItem item)
        {
            entities.MenuItems.AddObject(item);
        }

        public void delete(MenuItem item)
        {
            entities.MenuItems.DeleteObject(item);
        }

        public void save()
        {
            entities.SaveChanges();
        }
    }
}
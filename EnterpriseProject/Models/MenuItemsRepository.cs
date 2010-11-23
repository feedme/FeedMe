using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnterpriseProject.Models
{
    public class MenuItemsRepository
    {
        FeedMeEntities entities = new FeedMeEntities();

        public IQueryable<MenuItems> FindAllItems()
        {
            return entities.MenuItems;
        }

        public Item GetMenuItem(System.Guid guid)
        {
            return entities.Items.FirstOrDefault(i => i.ItemId == guid);
        }

        public IQueryable<Item> GetItemsByVendorId(System.Guid guid)
        {
            return entities.Items.Where(i => i.VendorId == guid);
        }

        public void add(Item item)
        {
            entities.Items.AddObject(item);
        }



        public void delete(Item item)
        {
            entities.Items.DeleteObject(item);
        }

        public void save()
        {
            entities.SaveChanges();
        }
    }
}
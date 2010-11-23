using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnterpriseProject.Models
{
    public class ItemsRepository
    {
        FeedMeEntities entities = new FeedMeEntities();

        public IQueryable<Item> FindAllItems()
        {
            return entities.Items;
        }

        public Item GetItem(System.Guid guid)
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

        public void addtomenu(System.Guid itemid, System.Guid menuid)
        {
            MenuItems item = new MenuItems();
            item.ItemId = itemid;
            item.MenuId = menuid;
            entities.MenuItems.AddObject(item);
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
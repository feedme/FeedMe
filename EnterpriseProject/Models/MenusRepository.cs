using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnterpriseProject.Models
{
    public class MenusRepository
    {
        FeedMeEntities entities = new FeedMeEntities();

        public IQueryable<Menu> FindAllMenus()
        {
            return entities.Menus;
        }

        public Menu GetMenu(System.Guid guid)
        {
            return entities.Menus.FirstOrDefault(i => i.MenuId == guid);
        }

        public IQueryable<Menu> GetMenusByVendorId(System.Guid guid)
        {
            return entities.Menus.Where(i => i.VendorId == guid);
        }

        public void add(Menu menu)
        {
            entities.Menus.AddObject(menu);
        }

        public void delete(Menu menu)
        {
            entities.Menus.DeleteObject(menu);
        }

        public void save()
        {
            entities.SaveChanges();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnterpriseProject.Models
{
    public class VendorsRepository
    {
        FeedMeEntities entities = new FeedMeEntities();

        public IQueryable<Vendor> FindAllVendors()
        {
            return entities.Vendors;
        }

        public Vendor GetVendor(System.Guid guid)
        {
            return entities.Vendors.FirstOrDefault(i => i.VendorId == guid);
        }

        public void add(Vendor vendor)
        {
            entities.Vendors.AddObject(vendor);
        }

        public void delete(Vendor vendor)
        {
            entities.Vendors.DeleteObject(vendor);
        }

        public void save()
        {
            entities.SaveChanges();
        }
    }
}
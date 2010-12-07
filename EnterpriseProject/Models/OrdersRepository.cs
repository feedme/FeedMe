using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnterpriseProject.Models
{
    public class OrdersRepository
    {
        FeedMeEntities entities = new FeedMeEntities();

        public IQueryable<Order> FindAllOrders()
        {
            return entities.Orders;
        }

        public Order GetOrder(System.Guid guid)
        {
            return entities.Orders.FirstOrDefault(i => i.OrderId == guid);
        }

        public IQueryable<Order> GetOrdersByVendorId(System.Guid guid)
        {
            return entities.Orders.Where(i => i.VendorId == guid);
        }

        public IQueryable<Order> GetOrdersByUserId(System.Guid guid)
        {
            return entities.Orders.Where(i => i.UserId == guid);
        }

        public IQueryable<Order> GetOrdersByStatusAndUserId(String status,Guid id)
        {
            return entities.Orders.Where(i => i.Status == status).Where(i => i.UserId == id);
        }

        public void add(Order order)
        {
            entities.Orders.AddObject(order);
        }

        public void delete(Order order)
        {
            entities.Orders.DeleteObject(order);
        }

        public void save()
        {
            entities.SaveChanges();
        }
    }
}
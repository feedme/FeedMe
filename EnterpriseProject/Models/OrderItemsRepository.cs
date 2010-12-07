using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnterpriseProject.Models
{
    public class OrdersItemsRepository
    {
        FeedMeEntities entities = new FeedMeEntities();

        public IQueryable<OrderItem> FindAllOrderItems()
        {
            return entities.OrderItems;
        }

        public IQueryable<OrderItem> GetOrderItemsByOrderId(System.Guid guid)
        {
            return entities.OrderItems.Where(i => i.OrderId == guid);
        }

        public OrderItem GetOrderItem(System.Guid guid)
        {
            return entities.OrderItems.FirstOrDefault(i => i.OrderItemId == guid);
        }

        public void add(OrderItem orderitem)
        {
            entities.OrderItems.AddObject(orderitem);
        }

        public void delete(OrderItem orderitem)
        {
            entities.OrderItems.DeleteObject(orderitem);
        }

        public void save()
        {
            entities.SaveChanges();
        }
    }
}
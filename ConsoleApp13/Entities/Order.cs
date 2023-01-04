using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp13.Entities.Enum;

namespace ConsoleApp13.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            OrderItems.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            OrderItems.Remove(item);
        }
        public double Total()
        {
            double total = 0.0;
            foreach (OrderItem OrderItems in OrderItems)
            {
                total += OrderItems.SubTotal();
            }
            return total;
        }

    }
}

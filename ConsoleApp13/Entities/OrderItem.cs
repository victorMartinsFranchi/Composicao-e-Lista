using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public int Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {
        }

        public OrderItem(int quantity, int price)
        {
            Quantity = quantity;
            Price = price;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }
    }
}

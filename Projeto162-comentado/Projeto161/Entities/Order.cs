using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Projeto161.Entities.Enums;
using System.Globalization;

namespace Projeto161.Entities
{
    class Order
    {
        public OrderStatus status { get; set; }
        public DateTime moment = DateTime.Now;
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order() { }
        public Order(OrderStatus status, DateTime moment)
        {
            this.status = status;
            this.moment = moment;
        }


        public void AddItem(OrderItem items)
        {
            Items.Add(items);
        }

        public void RemoveItem(OrderItem items)
        {
            Items.Remove(items);
        }

        public double Total()
        {
            return Items.Sum(item => item.subtotal());
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("ORDER SUMMARY");
            sb.AppendLine("Order Moment: " + moment);
            sb.AppendLine("Order Status: " + status);
            sb.AppendLine("Order items:");
            foreach (var item in Items)
            {
                sb.AppendLine(item.product.NameProduct + ", " +
                    item.quantity + " units, " +
                    "$" + item.product.PriceProduct.ToString("F2") +
                    " each, Subtotal: $" + item.subtotal().ToString("F2"));
            }

            sb.AppendLine("Total: $" + Total().ToString("F2"));
            return sb.ToString();

        }
    }
}

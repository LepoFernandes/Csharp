using Projeto159.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto159.Entities
{
    class Order
    {
        public int OrderId { get; set; }
        public OrderStatus Status { get; set; } = OrderStatus.Pending;

        public Order()
        {

        }

        public Order(int orderId, OrderStatus status)
        {
            OrderId = orderId;
            Status = status;
        }

        public void ChangeStatus(OrderStatus newStatus)
        {
            Status = newStatus;
        }
    }
}

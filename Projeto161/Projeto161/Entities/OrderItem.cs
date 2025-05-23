﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto161.Entities
{
    class OrderItem
    {
        public int quantity { get; set; }
        public double price { get; set; }

        public Product product { get; set; }

        public OrderItem() { }
        public OrderItem(int quantity, double price, Product product)
        {
            this.quantity = quantity;
            this.price = price;
            this.product = product;
        }

        public double subtotal()
        {
            return quantity * price;
        }
    }
}

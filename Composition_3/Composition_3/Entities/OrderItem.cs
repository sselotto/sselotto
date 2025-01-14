﻿using System;
using System.Globalization;


namespace Composition_3.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public Double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return  Quantity * Price;
        }

        public override string ToString()
        {
            return Product.Name
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
            +", Quantity: "
            + Quantity
            + ", Subtotal: $"
            + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

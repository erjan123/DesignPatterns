using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.SimpleFactory3
{
    class DiscountedOrder : IOrder
    {
        public int Amount { get; }
        public double Price { get; }
        public double Discount { get; }
        public DiscountedOrder(int amount, double price, double discount)
        {
            Amount = amount;
            Price = price;
            Discount = discount;
        }
        public double CalculatePrice()
        {
            return Amount * Price * ((100 - Discount) / 100);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.SimpleFactory3
{
    class RegularOrder : IOrder
    {
        public int Amount { get; }
        public double Price { get; }

        public RegularOrder(int amount, double price)
        {
            Amount = amount;
            Price = price;
        }
        public double CalculatePrice()
        {
            return Amount * Price;
        }
    }
}

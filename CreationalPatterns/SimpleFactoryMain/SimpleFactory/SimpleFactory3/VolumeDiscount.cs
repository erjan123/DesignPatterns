using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.SimpleFactory3
{
    class VolumeDiscount : IOrder
    {
        public int Amount { get; }
        public double Price { get; }
        public int MinOrder { get; }
        public double Discount { get; }

        public VolumeDiscount(int amount, int orderTotal, double price, double discount)
        {
            Amount = amount;
            MinOrder = orderTotal;
            Price = price;
            Discount = discount;
        }
        public double CalculatePrice()
        {
            if(Amount < MinOrder)
            {
                return Amount * Price;
            }
            else
            {
               return  Amount * Price * ((100 - Discount) / 100);
            }
        }
    }
}

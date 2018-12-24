using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.SimpleFactory3
{
    public static class SimpleOrderFactory3
    {
        public static IOrder SubmitOrder(int amount, double price)
        {
            return new RegularOrder(amount, price);
        }

        public static IOrder SubmitOrder(int amount, double price, double discount)
        {
            return new DiscountedOrder(amount, price, discount);
        }

        public static IOrder SubmitOrder(int amount, int minOrder, double price, double discount)
        {
            return new VolumeDiscount(amount,minOrder, price, discount);
        }
    }
}

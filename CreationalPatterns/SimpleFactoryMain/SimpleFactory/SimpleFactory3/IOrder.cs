using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.SimpleFactory3
{
    public interface IOrder
    {
        int Amount { get; }
        double Price { get; }

        double CalculatePrice();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        private const double CoffeeMilliliters= 50;
        private const decimal CofeePrice = 3.50m;
        public Coffee(string name, decimal price, double caffeine) 
            : base(name, CofeePrice, CoffeeMilliliters)
        {
            this.Caffeine = caffeine;
        }

        public double Caffeine { get; set; }
    }
}

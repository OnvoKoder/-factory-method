using System;
using System.Collections.Generic;
using System.Text;

namespace Laba15
{
    class NYStyleClamPizza: Pizza
    {
        public NYStyleClamPizza()
        {
            name = "NY Style Clam Pizza";
            dough = "Very thin dough";
            sauce = "Cesar sauce";

            toppings.Add("Nothing");

        }
        public void cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}

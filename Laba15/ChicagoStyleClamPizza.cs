using System;
using System.Collections.Generic;
using System.Text;

namespace Laba15
{
    class ChicagoStyleClamPizza: Pizza
    {
        public ChicagoStyleClamPizza()
        {
            name = "Chicago Style Clam Pizza";
            dough = "Very thin dough";
            sauce = "Plum garlic sauce";

            toppings.Add("Nothing");
        }
        public void cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Laba15
{
    class NYStyleVeggiePizza: Pizza
    {
        public NYStyleVeggiePizza()
        {
            name = "NY Style Veggie Pizza";
            dough = "Usual dough";
            sauce = "Mushroom sauce";

            toppings.Add("Grated Reggiano Cheese");

        }
        public void cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}

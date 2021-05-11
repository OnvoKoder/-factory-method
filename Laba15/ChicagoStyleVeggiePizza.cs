using System;
using System.Collections.Generic;
using System.Text;

namespace Laba15
{
    class ChicagoStyleVeggiePizza: Pizza
    {
        public ChicagoStyleVeggiePizza()
        {
            name = "Chicago Style Veggie Pizza";
            dough = "Very thin dough";
            sauce = "Hot chili sauce";

            toppings.Add("Parmesan Cheese");
        }
        public void cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Laba15
{
    class ChicagoStylePepperoniPizza: Pizza
    {
        public ChicagoStylePepperoniPizza()
        {
            name = "Chicago Style Pepperoni Pizza";
            dough = "Usual  Dough";
            sauce = "Cheese sauce";

            toppings.Add("Сheddar Сheese");
        }
        public void cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}

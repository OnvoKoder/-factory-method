using System;
using System.Collections.Generic;
using System.Text;

namespace Laba15
{
    class NYStylePepperoniPizza: Pizza
    {
        public NYStylePepperoniPizza()
        {
            name = "NY Style PepperoniPizza";
            dough = "Usual dough";
            sauce = "One thousand island";

            toppings.Add(" Mozzarella Cheese");

        }
        public void cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}

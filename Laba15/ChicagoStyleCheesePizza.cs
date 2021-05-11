using System;
using System.Collections.Generic;
using System.Text;

namespace Laba15
{
    class ChicagoStyleCheesePizza: Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            name = "Chicago Style Deep Dish Cheese Pizza";
            dough = "Extra Thick Crust Dough";
            sauce = "Plum tomato Sauce";

            toppings.Add("Shredded Mozzarella Cheese");
        }

        public void cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}

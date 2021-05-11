using System;
using System.Collections.Generic;
using System.Text;

namespace Laba15
{
    public abstract class Pizza
    {
        protected string name;
        protected string dough;
        protected string sauce;

        protected List<string> toppings = new List<string>();

        public void prepare()
        {
            Console.WriteLine("Preparing" + name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings: ");

            foreach (string topping in toppings)
            {
                Console.WriteLine(" " + topping);
            }
        }

        public void bake ()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public void cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public void box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public string getName()
        {
            return name;
        }
    }
}

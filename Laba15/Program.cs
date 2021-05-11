using System;

namespace Laba15
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();
            Pizza pizza;
            pizza = nyStore.orderPizza("cheese");
            Console.WriteLine("Ethan ordered a " +pizza.getName() + "\n");
            pizza = nyStore.orderPizza("pepperoni");
            Console.WriteLine("Alan ordered a " + pizza.getName() + "\n");
            pizza = nyStore.orderPizza("veggie");
            Console.WriteLine("Mark ordered a " + pizza.getName() + "\n");
            pizza = nyStore.orderPizza("clam");
            Console.WriteLine("Joseph ordered a " + pizza.getName() + "\n");
            pizza = chicagoStore.orderPizza("cheese");
            Console.WriteLine("Joel ordered a " +pizza.getName() + "\n");
            pizza = chicagoStore.orderPizza("pepperoni");
            Console.WriteLine("Jony ordered a " + pizza.getName() + "\n");
            pizza = chicagoStore.orderPizza("veggie");
            Console.WriteLine("Garry ordered a " + pizza.getName() + "\n");
            pizza = chicagoStore.orderPizza("clam");
            Console.WriteLine("Steve ordered a " + pizza.getName() + "\n");
        }
    }
}

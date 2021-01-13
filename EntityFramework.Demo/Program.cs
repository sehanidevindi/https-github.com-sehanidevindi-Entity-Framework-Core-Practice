using System;

namespace EntityFramework.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PizzaContext
                ("Data Source=LAPTOP-DM8ANEE6\\SQLEXPRESS;Initial Catalog=PizzaMenu;Integrated Security=True");
            var provider = new PizzaProvider(context);
            var pizza = provider.Get(1);
            Console.WriteLine($"Order {pizza.Pizza_name} with ingredients: {pizza.Ingredients}");

            var repo = new PizzaRepo(context);
            var pizza1 = provider.Get(2);
            
            repo.Delete(pizza1);
        }
    }
}

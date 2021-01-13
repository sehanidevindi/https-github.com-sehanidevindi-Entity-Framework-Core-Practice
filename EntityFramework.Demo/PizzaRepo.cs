using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.Demo
{
    internal class PizzaRepo : IPizzaRepo
    {
        private readonly PizzaContext pizzaContext;
        public PizzaRepo(PizzaContext pizzaContext)
        {
            this.pizzaContext = pizzaContext;
        }
        
        public Pizza Create(string pizza_name,
            string ingredients,
            int price)
        {
            var response = pizzaContext.Add(new Pizza
            {
                Pizza_name = pizza_name,
               Ingredients = ingredients,
               Price       = price
            });
            pizzaContext.SaveChanges();
            return response.Entity;
        }

        public void Delete(Pizza employee)
        {
            pizzaContext.Remove(employee);
            pizzaContext.SaveChanges();
        }

        public Pizza Update(Pizza pizza)
        {
            var response = pizzaContext.Update(pizza);
            pizzaContext.SaveChanges();
            return response.Entity;
        }
    }
}

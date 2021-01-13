using System;
using System.Collections.Generic;
using System.Linq;

namespace EntityFramework.Demo
{
    internal class PizzaProvider :IPizzaProvider
    {
        private readonly PizzaContext pizzaContext;
        public PizzaProvider(PizzaContext pizzaContext)
        {
            this.pizzaContext = pizzaContext;
        }
        public Pizza Get(int id) 
        {
           return pizzaContext.Employees.Where(e => e.Id == id).FirstOrDefault();
        }
    }
}

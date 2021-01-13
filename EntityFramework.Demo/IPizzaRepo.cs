using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.Demo
{
    internal interface IPizzaRepo
    {
        Pizza Create(string pizza_name,
            string ingredients,
            int price);

        Pizza Update(Pizza pizza);

        void Delete(Pizza pizza);

    }
}

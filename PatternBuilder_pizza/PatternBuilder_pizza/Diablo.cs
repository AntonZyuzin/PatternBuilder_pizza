using System;
using System.Collections.Generic;
using System.Text;

namespace PatternBuilderPizza
{
    class Diablo : PizzaInterface
    {
        public void SetDough(string dough)
        {
            Console.WriteLine("Ингредиенты:\n" + dough);
        }

        public void SetFilling(string filling)
        {
            Console.WriteLine(filling);
        }

        public void SetSauce(string sauce)
        {
            Console.WriteLine(sauce);
        }
    }
}

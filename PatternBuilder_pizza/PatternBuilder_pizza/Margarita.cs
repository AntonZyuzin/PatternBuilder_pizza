using System;
using System.Collections.Generic;
using System.Text;

namespace PatternBuilderPizza
{
    class Margarita : Pizza
    {
        public void setDough(string dough)
        {
            Console.WriteLine("Ингредиенты:\n" + dough);
        }

        public void setFilling(string filling)
        {
            Console.WriteLine(filling);
        }

        public void setSauce(string sauce)
        {
            Console.WriteLine(sauce);
        }
    }
}

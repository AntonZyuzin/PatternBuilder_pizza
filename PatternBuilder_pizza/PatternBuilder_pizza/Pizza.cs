using System;
using System.Collections.Generic;
using System.Text;

namespace PatternBuilderPizza
{
    interface Pizza
    {
        void SetDough(string dough);
        void SetSauce(string sauce);
        void SetFilling(string filling);
    }
}

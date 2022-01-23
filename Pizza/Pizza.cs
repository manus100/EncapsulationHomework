using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class Pizza
    {
        string name;
        Dough dough;
        Topping topping;

        public Pizza  (string name,  Dough dough, Topping topping)
        {
            this.name = name;
            this.dough = dough;
            this.topping = topping;
        }
    }
}

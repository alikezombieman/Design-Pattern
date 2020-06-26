using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Decorator
{
    class AddFurniture : IComponent
    {
        IComponent component;

        public AddFurniture(IComponent c)
        {
            component = c;
        }

        public string Operation()
        {
            string a = component.Operation();
            a += "has furniture ";
            return a;
        }
    }
}

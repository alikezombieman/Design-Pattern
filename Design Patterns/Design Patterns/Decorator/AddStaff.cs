using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Decorator
{
    class AddStaff : IComponent
    {
        IComponent component;

        public AddStaff(IComponent c)
        {
            component = c;
        }

        public string Operation()
        {
            string a = component.Operation();
            a += "has staff ";
            return a;
        }
    }
}

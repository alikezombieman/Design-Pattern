using Design_patterns.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_patterns.Decorator
{
    class Component : IComponent
    {
        public string Operation()
        {
            return "Structure ";
        }
    }
}

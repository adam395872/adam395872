using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class DisplayAsGraphical : IDisplayBehaviour
    {
        public void display()
        {
            Console.WriteLine("the duck with Graphical display");
        }
    }
}

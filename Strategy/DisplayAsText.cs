using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class DisplayAsText : IDisplayBehaviour
    {
        public void display()
        {
            Console.WriteLine("the duck with text display");
        }
    }
}

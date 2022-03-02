using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class SimpleFlying : IFlyBehaviour
    {
        public void fly()
        {
            Console.WriteLine("The duck which flies simple way");
        }
    }
}

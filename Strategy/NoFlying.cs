using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class NoFlying : IFlyBehaviour
    {
        public void fly()
        {
            Console.WriteLine("The duck which does not fly");
        }
    }
}

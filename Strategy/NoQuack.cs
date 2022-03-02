using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class NoQuack : IQuackBehaviour
    {
        public void quack()
        {
            Console.WriteLine("The duck which does not quack ");
        }
    }
}

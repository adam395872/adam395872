using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class SimpleQuack : IQuackBehaviour
    {
        public void quack()
        {
            Console.WriteLine("The duck with simple quack");
        }
    }
}

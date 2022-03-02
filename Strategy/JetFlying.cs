﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class JetFlying : IFlyBehaviour
    {
        public void fly()
        {
            Console.WriteLine("The duck with jet flying behaviour invoked");
        }
    }
}

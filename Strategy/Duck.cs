using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Duck
    {
        public IFlyBehaviour FlyBehaviour { get; set; }
        public IQuackBehaviour QuackBehaviour { get; set; }

        public IDisplayBehaviour DisplayBehaviour { get; set; }

        public Duck(IFlyBehaviour flyBehaviour, IQuackBehaviour quackBehaviour, IDisplayBehaviour displayBehaviour)
        {
            this.FlyBehaviour = flyBehaviour;
            this.QuackBehaviour = quackBehaviour;
            this.DisplayBehaviour = displayBehaviour;

        }
        static void Main(string[] args)
        {
            var duck = new Duck(flyBehaviour : new JetFlying(),
                quackBehaviour: new SimpleQuack(), 
                displayBehaviour: new DisplayAsGraphical());
            duck.Fly();
            duck.Quack();
            duck.Display();
        }

        public void Fly()
        {
           this.FlyBehaviour.fly();
        }

        public void Quack()
        {
            this.QuackBehaviour.quack();
        }
        public void Display()
        {
            this.DisplayBehaviour.display();
        }
    }
}

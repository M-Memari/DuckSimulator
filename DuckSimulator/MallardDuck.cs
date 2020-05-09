using System;

namespace DuckSimulator
{
    public class MallardDuck : Duck
    {
        public MallardDuck() : base(CanFly.CreateInstance(), Quack.CreateInstance())
        {
            
        }

        protected override void Display()
        {
            Console.WriteLine("I'm a Mallard Duck.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DuckSimulator
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck() : base(CanNotFly.CreateInstance(), Mute.CreateInstance())
        {
        }

        protected override void Display()
        {
            Console.WriteLine("I'm a decoy duck");
        }
    }
}

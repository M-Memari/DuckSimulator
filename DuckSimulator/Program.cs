using System.Collections.Generic;

namespace DuckSimulator
{
    internal static class Program
    {
        private static void Main()
        {
            // The goal was to max code reuse, dynamically change object behaviour at runtime
            // and ease of adding new subclasses.

            var myDucks = new List<Duck>()
            {
                new DecoyDuck(),
                new MallardDuck()
            };
            //polymorphism
            foreach (var duck in myDucks)
            {
                duck.MakeSound();
                duck.Fly();
            }
        }
    }
}

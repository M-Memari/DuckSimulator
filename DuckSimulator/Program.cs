using System.Collections.Generic;

namespace DuckSimulator
{
    internal static class Program
    {
        private static void Main()
        {
            var myDucks = new List<Duck>()
            {
                new DecoyDuck(),
                new MallardDuck()
            };
            foreach (var duck in myDucks)
            {
                duck.MakeSound();
                duck.Fly();
            }
        }
    }
}

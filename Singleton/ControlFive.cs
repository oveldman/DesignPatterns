using System;
using Singleton.Pattern;

namespace Singleton
{
    public class ControlFive
    {
        public void Run()
        {
            var worldOne = World.Instance();
            var worldTwo = World.Instance();

            if (worldOne == worldTwo)
            {
                Console.WriteLine($"WorldOne: {worldOne.Seed} and WorldTwo: {worldTwo.Seed}!");
            }
        }
    }
}

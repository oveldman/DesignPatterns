using System;
using FlyWeight.Pattern;

namespace FlyWeight
{
    public class ControlEleven
    {
        public void Run()
        {
            ShipFactory factory = new ShipFactory();
            var shipOne = factory.GetCargoShip();
            var shipTwo = factory.GetCargoShip();
            var shipThree = factory.GetCruiseShip();
            var shipFour = factory.GetCruiseShip();

            shipOne.SetSail();
            shipOne.SetSail();
            shipTwo.SetSail();
            shipOne.SetSail();
            shipThree.SetSail();
            shipThree.SetSail();
            shipFour.SetSail();
            shipThree.SetSail();
        }
    }
}

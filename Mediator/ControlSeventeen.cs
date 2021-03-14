using System;
using Mediator.Pattern;

namespace Mediator
{
    public class ControlSeventeen
    {
        public void Run()
        {
            BattleField battleField = new WaterBattleField();
            Ship shipOne = new BattleShip("Kees");
            Ship shipTwo = new BattleShip("Arjan");
            Ship shipThree = new BattleShip("White");

            battleField.Register(shipOne);
            battleField.Register(shipTwo);
            battleField.Register(shipThree);

            shipOne.Attack("Arjan");
            shipThree.Attack("Kees");
            shipTwo.Attack("White");
            shipOne.Attack("Weird");
        }
    }
}

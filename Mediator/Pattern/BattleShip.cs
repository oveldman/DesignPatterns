using System;
namespace Mediator.Pattern
{
    public class BattleShip : Ship
    {
        public BattleShip(string shipName) : base(shipName)
        {
        }

        public override void Attack(string shipName)
        {
            Console.WriteLine(Name + " tries to attack: " + shipName);
            BattleField.Attack(shipName);
        }

        public override void TakeDamage()
        {
            Console.WriteLine(Name + " got some damage!");
        }
    }
}

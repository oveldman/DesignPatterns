using System;
namespace Mediator.Pattern
{
    public abstract class Ship
    {
        public BattleField BattleField { get; set; }

        public string Name { get; private set; }

        public Ship(string name)
        {
            Name = name;
        }

        public abstract void Attack(string shipName);
        public abstract void TakeDamage();
    }
}

using System;
namespace Mediator.Pattern
{
    public abstract class BattleField
    {
        public abstract void Register(Ship newShip);
        public abstract void Attack(string name);
    }
}

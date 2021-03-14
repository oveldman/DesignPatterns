using System;
using System.Collections.Generic;

namespace Mediator.Pattern
{
    public class WaterBattleField : BattleField
    {
        private Dictionary<string, Ship> _allShips = new Dictionary<string, Ship>();

        public override void Attack(string name)
        {
            if (_allShips.ContainsKey(name))
            {
                _allShips[name].TakeDamage();
            }
            else
            {
                Console.WriteLine("The attack failed!");
            }
        }

        public override void Register(Ship ship)
        {
            if (!_allShips.ContainsKey(ship.Name))
            {
                ship.BattleField = this;
                _allShips.Add(ship.Name, ship);
            }
        }
    }
}

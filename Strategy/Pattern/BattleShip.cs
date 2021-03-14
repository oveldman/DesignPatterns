using System;
namespace Strategy.Pattern
{
    public class BattleShip
    {
        private string _name;
        private AttackStrategy _attackStrategy;

        public BattleShip(string name)
        {
            _name = name;

            Console.WriteLine("Ship " + _name + " is ready to attack, sir!");

            _attackStrategy = new TorpedoStrategy();
        }

        public void SetAttackStrategy(AttackStrategy attackStrategy)
        {
            _attackStrategy = attackStrategy;
        }

        public void Attack()
        {
            _attackStrategy.Attack();
        }
    }
}

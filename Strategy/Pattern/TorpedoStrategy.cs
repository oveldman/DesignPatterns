using System;
namespace Strategy.Pattern
{
    public class TorpedoStrategy : AttackStrategy
    {
        public override void Attack()
        {
            Console.WriteLine("Lanching torpedio!");
        }
    }
}

using System;
namespace Strategy.Pattern
{
    public class MachineGunStrategy : AttackStrategy
    {
        public override void Attack()
        {
            Console.WriteLine("Firing the machine guns!!");
        }
    }
}

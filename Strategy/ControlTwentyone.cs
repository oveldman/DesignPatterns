using System;
using Strategy.Pattern;

namespace Strategy
{
    public class ControlTwentyone
    {
        public void Run()
        {
            BattleShip ship = new BattleShip("Primo");
            ship.SetAttackStrategy(new MachineGunStrategy());
            ship.Attack();
            ship.SetAttackStrategy(new TorpedoStrategy());
            ship.Attack();
        }
    }
}

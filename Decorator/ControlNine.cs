using System;
using Decorator.Pattern;

namespace Decorator
{
    public class ControlNine
    {
        public void Run()
        {
            Ship currentShip = new BasicShip();
            CruiseShip upgradedShip = new CruiseShip();
            AdvancedShip biggerUpgradedShip = new AdvancedShip();

            upgradedShip.SetShip(currentShip);
            biggerUpgradedShip.SetShip(upgradedShip);

            biggerUpgradedShip.Sail();
        }
    }
}

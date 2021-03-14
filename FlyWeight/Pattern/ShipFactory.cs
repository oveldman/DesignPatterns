using System;
using System.Collections.Generic;

namespace FlyWeight.Pattern
{
    public class ShipFactory
    {
        private Dictionary<string, Ship> _ships;

        public ShipFactory()
        {
            _ships = new Dictionary<string, Ship>();
        }

        public CargoShip GetCargoShip()
        {
            var baseShip = GetShip(typeof(CargoShip));
            return new CargoShip(baseShip);
        }

        public CruiseShip GetCruiseShip()
        {
            var baseShip = GetShip(typeof(CruiseShip));
            return new CruiseShip(baseShip);
        }

        private Ship GetShip(Type schipType)
        {
            Ship baseShip = null;

            if (_ships.ContainsKey(schipType.Name))
            {
                baseShip = _ships[schipType.Name];
            }
            else
            {
                switch (schipType.Name)
                {
                    case "CargoShip":
                        baseShip = new Ship("M.S Cargo", 86, 10, 1500);
                        break;
                    case "CruiseShip":
                        baseShip = new Ship("M.S. Cruise", 200, 20, 5000);
                        break;
                    default:
                        break;
                }

                if (baseShip != null)
                {
                    _ships.Add(schipType.Name, baseShip);
                }
            }

            return baseShip;
        }
    }
}

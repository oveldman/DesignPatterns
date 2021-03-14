using System;
using Prototype.Pattern;

namespace Prototype
{
    public class ControlFourth
    {
        public void Run()
        {
            var locationManager = new LocationManager();
            locationManager["Amsterdam"] = new Location(4.899431, 52.379189, "Windmills");
            locationManager["Rotterdam"] = new Location(4.466637, 51.905445, "Euromast");
            locationManager["Maastricht"] = new Location(5.690973, 50.851368, "Vrijthof");

            Location rotterdam = locationManager["Rotterdam"].Clone() as Location;
        }
    }
}

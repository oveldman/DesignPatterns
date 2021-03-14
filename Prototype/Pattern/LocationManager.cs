using System;
using System.Collections.Generic;

namespace Prototype.Pattern
{
    public class LocationManager
    {
        private Dictionary<string, LocationPrototype> _location =
            new Dictionary<string, LocationPrototype>();

        public LocationPrototype this[string key]
        {
            get { return _location[key]; }
            set { _location.Add(key, value); }
        }
    }
}

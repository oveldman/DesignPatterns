using System;
using Proxy.Pattern;

namespace Proxy
{
    public class ControlTwelve
    {
        public void Run()
        {
            IService proxy = new SuperProxy();
            proxy.SendRequest();
        }
    }
}

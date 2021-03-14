using System;
namespace Proxy.Pattern
{
    public class WebService : IService
    {
        public WebService()
        {
        }

        public void SendRequest()
        {
            Console.WriteLine("Sending request...");
        }
    }
}

using System;
namespace Proxy.Pattern
{
    public class SuperProxy : IService
    {
        private IService _webService;

        public SuperProxy()
        {
        }

        public void SendRequest()
        {
            Console.WriteLine("Using proxy for sending request");

            if (_webService == null)
            {
                _webService = new WebService();
            }

            _webService.SendRequest();
        }
    }
}

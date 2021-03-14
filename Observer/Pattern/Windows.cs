using System;
namespace Observer.Pattern
{
    public class Windows : Observer
    {
        private string _applicationVersion;
        private Organisator _organisator;

        public Windows(Organisator organisator)
        {
            _organisator = organisator;
        }

        public override void Update()
        {
            _applicationVersion = _organisator.ApplicationVersion;
            Console.WriteLine("Windows said OK to version: " + _applicationVersion);
        }
    }
}

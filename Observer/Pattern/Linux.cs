using System;
namespace Observer.Pattern
{
    public class Linux : Observer
    {
        private string _applicationVersion;
        private Organisator _organisator;

        public Linux(Organisator organisator)
        {
            _organisator = organisator;
        }

        public override void Update()
        {
            _applicationVersion = _organisator.ApplicationVersion;
            Console.WriteLine("Linux said Yeah to version: " + _applicationVersion);
        }
    }
}

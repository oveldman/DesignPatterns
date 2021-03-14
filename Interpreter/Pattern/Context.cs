using System;
namespace Interpreter.Pattern
{
    public class Context
    {
        private string _original;

        public Context(string data)
        {
            _original = data;
        }

        public string Original
        {
            get
            {
                return _original;
            }
        }
    }
}

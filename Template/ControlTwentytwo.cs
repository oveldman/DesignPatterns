using System;
using Template.Pattern;

namespace Template
{
    public class ControlTwentytwo
    {
        public void Run()
        {
            Computer windows = new Windows();
            Computer linux = new Linux();

            windows.RunCommand("ls");
            linux.RunCommand("ls");
        }
    }
}

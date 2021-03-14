using System;
using Observer.Pattern;

namespace Observer
{
    public class ControlNineteen
    {
        public void Run()
        {
            Organisator organisator = new Organisator();
            Windows windows = new Windows(organisator);

            organisator.Attach(windows);
            organisator.Attach(new Linux(organisator));

            organisator.ApplicationVersion = "1.0";
            organisator.Notify();

            organisator.Detach(windows);

            organisator.ApplicationVersion = "2.0";
            organisator.Notify();
        }
    }
}

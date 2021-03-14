using System;
using Builder.Builders;

namespace Builder
{
    public class ControlSecond
    {
        public void Run()
        {
            Director director = new Director();

            AbstractPcBuilder intelBuilder = new IntelBuilder();
            AbstractPcBuilder amdBuilder = new AmdBuilder();

            director.Construct(intelBuilder);
            PC intelPC = intelBuilder.GetPC();
            intelPC.Show();

            director.Construct(amdBuilder);
            PC amdPC = amdBuilder.GetPC();
            amdPC.Show();
        }
    }
}

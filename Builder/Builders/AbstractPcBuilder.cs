using System;
namespace Builder.Builders
{
    public abstract class AbstractPcBuilder
    {
        public abstract void BuildProcessor();
        public abstract void BuildVideoCard();
        public abstract PC GetPC();
    }
}

using System;
namespace Builder.Builders
{
    public class IntelBuilder : AbstractPcBuilder
    {
        private PC _pc = new PC();

        public override void BuildProcessor()
        {
            _pc.Add("I7");
        }

        public override void BuildVideoCard()
        {
            _pc.Add("GTX 3060");
        }

        public override PC GetPC()
        {
            return _pc;
        }
    }
}

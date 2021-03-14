using System;
namespace Builder.Builders
{
    public class AmdBuilder : AbstractPcBuilder
    {
        private PC _pc = new PC();

        public override void BuildProcessor()
        {
            _pc.Add("Ryzen");
        }

        public override void BuildVideoCard()
        {
            _pc.Add("Radeon");
        }

        public override PC GetPC()
        {
            return _pc;
        }
    }
}

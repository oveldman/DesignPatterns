using System;
using Builder.Builders;

namespace Builder
{
    public class Director
    {
        public AbstractPcBuilder Construct(AbstractPcBuilder builder)
        {
            builder.BuildProcessor();
            builder.BuildVideoCard();

            return builder;
        }
    }
}

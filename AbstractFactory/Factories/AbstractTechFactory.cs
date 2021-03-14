using System;
using AbstractFactory.Products;

namespace AbstractFactory.Factories
{
    public abstract class AbstractTechFactory
    {
        public abstract AbstractPhoneProduct CreatePhoneProduct();
        public abstract AbstractTabletProduct CreateTabletProduct();
    }
}

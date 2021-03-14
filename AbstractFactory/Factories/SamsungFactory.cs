using System;
using AbstractFactory.Products;

namespace AbstractFactory.Factories
{
    public class SamsungFactory : AbstractTechFactory
    {
        public override AbstractPhoneProduct CreatePhoneProduct()
        {
            return new SmartphoneProduct();
        }

        public override AbstractTabletProduct CreateTabletProduct()
        {
            return new TabletProduct();
        }
    }
}

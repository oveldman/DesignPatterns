using System;
using AbstractFactory.Products;

namespace AbstractFactory.Factories
{
    public class AppleFactory : AbstractTechFactory
    {
        public override AbstractPhoneProduct CreatePhoneProduct()
        {
            return new IphoneProduct();
        }

        public override AbstractTabletProduct CreateTabletProduct()
        {
            return new IpadProduct();
        }
    }
}

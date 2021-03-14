using System;
using AbstractFactory.Factories;
using AbstractFactory.Products;

namespace AbstractFactory
{
    public class Client
    {
        private AbstractPhoneProduct _abstractPhoneProduct;
        private AbstractTabletProduct _abstractTabletProduct;

        public Client(AbstractTechFactory factory)
        {
            _abstractPhoneProduct = factory.CreatePhoneProduct();
            _abstractTabletProduct = factory.CreateTabletProduct();
        }

        public void CheckTech()
        {
            _abstractPhoneProduct.Call();
            _abstractTabletProduct.Teams();
        }
    }
}

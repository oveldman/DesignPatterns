using System;
namespace AbstractFactory.Products
{
    public class IpadProduct : AbstractTabletProduct
    {
        public override void Teams()
        {
            Console.WriteLine("I'm a Ipad!");
        }
    }
}

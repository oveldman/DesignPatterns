using System;
namespace AbstractFactory.Products
{
    public class TabletProduct : AbstractTabletProduct
    {
        public override void Teams()
        {
            Console.WriteLine("I'm a tablet!");
        }
    }
}

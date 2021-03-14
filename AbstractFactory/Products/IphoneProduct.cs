using System;
namespace AbstractFactory.Products
{
    public class IphoneProduct : AbstractPhoneProduct
    {
        public override void Call()
        {
            Console.WriteLine("I'm a Iphone!");
        }
    }
}

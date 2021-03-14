using System;
namespace AbstractFactory.Products
{
    public class SmartphoneProduct : AbstractPhoneProduct
    {
        public override void Call()
        {
            Console.WriteLine("I'm a smartphone!");
        }
    }
}

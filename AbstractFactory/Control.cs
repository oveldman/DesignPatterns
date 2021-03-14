using System;
using AbstractFactory.Factories;

namespace AbstractFactory
{
    public class Control
    {
        public void Run()
        {
            AbstractTechFactory appleFactory = new AppleFactory();
            Client appleClient = new Client(appleFactory);
            appleClient.CheckTech();

            AbstractTechFactory samsungFactory = new SamsungFactory();
            Client samsungClient = new Client(samsungFactory);
            samsungClient.CheckTech();
        }
    }
}
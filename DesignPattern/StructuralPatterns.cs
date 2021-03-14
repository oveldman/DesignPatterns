using System;
using Adapter;
using Brigde;
using Composite;
using Decorator;
using Facade;
using FlyWeight;
using Proxy;

namespace DesignPattern
{
    public class StructuralPatterns
    {
        public static void Start()
        {
            // 6. Adapter
            // https://www.dofactory.com/net/adapter-design-pattern
            Console.WriteLine("6. Adapter");
            // Convert the interface of a class into another interface clients expect.
            // Adapter lets classes work together that couldn't otherwise because of incompatible interfaces. 
            Console.WriteLine("------------------------------------");
            ControlSix adapter = new ControlSix();
            adapter.Run();
            Console.WriteLine("------------------------------------");

            // 7. Bridge
            // https://www.dofactory.com/net/bridge-design-pattern
            Console.WriteLine("7. Bridge");
            // Decouple an abstraction from its implementation so that the two can vary independently. 
            Console.WriteLine("------------------------------------");
            ControlSeven bridge = new ControlSeven();
            bridge.Run();
            Console.WriteLine("------------------------------------");

            // 8. Composite
            // https://www.dofactory.com/net/composite-design-pattern
            Console.WriteLine("8. Composite");
            // Compose objects into tree structures to represent part-whole hierarchies.
            // Composite lets clients treat individual objects and compositions of objects uniformly. 
            Console.WriteLine("------------------------------------");
            ControlEight composite = new ControlEight();
            composite.Run();
            Console.WriteLine("------------------------------------");

            // 9. Decorator
            // https://www.dofactory.com/net/decorator-design-pattern
            Console.WriteLine("9. Decorator");
            // Attach additional responsibilities to an object dynamically.
            // Decorators provide a flexible alternative to subclassing for extending functionality. 
            Console.WriteLine("------------------------------------");
            ControlNine decorator = new ControlNine();
            decorator.Run();
            Console.WriteLine("------------------------------------");

            // 10. Facade
            // https://www.dofactory.com/net/facade-design-pattern
            Console.WriteLine("10. Facade");
            // Provide a unified interface to a set of interfaces in a subsystem.
            // Façade defines a higher-level interface that makes the subsystem easier to use. 
            Console.WriteLine("------------------------------------");
            ControlTen facade = new ControlTen();
            facade.Run();
            Console.WriteLine("------------------------------------");

            // 11. FlyWeight
            // https://www.dofactory.com/net/flyweight-design-pattern
            Console.WriteLine("11. FlyWeight");
            // Use sharing to support large numbers of fine-grained objects efficiently.  
            Console.WriteLine("------------------------------------");
            ControlEleven flyWeight = new ControlEleven();
            flyWeight.Run();
            Console.WriteLine("------------------------------------");

            // 12. Proxy
            // https://www.dofactory.com/net/proxy-design-pattern
            Console.WriteLine("12. Proxy");
            // Provide a surrogate or placeholder for another object to control access to it.   
            Console.WriteLine("------------------------------------");
            ControlTwelve proxy = new ControlTwelve();
            proxy.Run();
            Console.WriteLine("------------------------------------");
        }
    }
}

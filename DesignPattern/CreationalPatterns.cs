using System;
using AbstractFactory;
using Builder;
using FactoryMethod;
using Prototype;
using Singleton;

namespace DesignPattern
{
    public class CreationalPatterns
    {
        public static void Start()
        {
            // 1. Abstract Factory
            // https://www.dofactory.com/net/abstract-factory-design-pattern
            Console.WriteLine("1. Abstract Factory");
            // Provide an interface for creating families of related or dependent objects without specifying their concrete classes.
            Console.WriteLine("------------------------------------");
            Control abstractFactory = new Control();
            abstractFactory.Run();
            Console.WriteLine("------------------------------------");

            // 2. Builder
            // https://www.dofactory.com/net/builder-design-pattern
            Console.WriteLine("2. Builder");
            // Separate the construction of a complex object from its representation so that the same
            // construction process can create different representations. 
            Console.WriteLine("------------------------------------");
            ControlSecond builder = new ControlSecond();
            builder.Run();
            Console.WriteLine("------------------------------------");

            // 3. Factory Method
            // https://www.dofactory.com/net/factory-method-design-pattern
            Console.WriteLine("3. Factory Method");
            // Define an interface for creating an object, but let subclasses decide which class to instantiate.
            // Factory Method lets a class defer instantiation to subclasses. 
            Console.WriteLine("------------------------------------");
            ControlThird factoryMethod = new ControlThird();
            factoryMethod.Run();
            Console.WriteLine("------------------------------------");

            // 4. Prototype
            // https://www.dofactory.com/net/prototype-design-pattern
            Console.WriteLine("4. Prototype");
            // Specify the kind of objects to create using a prototypical instance, and create new objects by copying this prototype. 
            Console.WriteLine("------------------------------------");
            ControlFourth prototype = new ControlFourth();
            prototype.Run();
            Console.WriteLine("------------------------------------");

            // 5. Singleton
            // https://www.dofactory.com/net/singleton-design-pattern
            Console.WriteLine("5. Singleton");
            // Ensure a class has only one instance and provide a global point of access to it. 
            Console.WriteLine("------------------------------------");
            ControlFive singleton = new ControlFive();
            singleton.Run();
            Console.WriteLine("------------------------------------");
        }
    }
}

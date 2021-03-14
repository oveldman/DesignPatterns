using System;
using ChainOfResponsibility;
using Command;
using Interpreter;
using Iterator;
using Mediator;
using Memento;
using Observer;
using State;
using Strategy;
using Template;
using Visitor;

namespace DesignPattern
{
    public class BehavioralPatterns
    {
        public static void Start()
        {
            // 13. Chain Of Responsibility
            // https://www.dofactory.com/net/chain-of-responsibility-design-pattern
            Console.WriteLine("13. Chain Of Responsibility");
            // Avoid coupling the sender of a request to its receiver by giving more than one object a chance to handle the request.
            // Chain the receiving objects and pass the request along the chain until an object handles it. 
            Console.WriteLine("------------------------------------");
            ControlThirteen chainOfResponsibility = new ControlThirteen();
            chainOfResponsibility.Run();
            Console.WriteLine("------------------------------------");

            // 14. Command
            // https://www.dofactory.com/net/command-design-pattern
            Console.WriteLine("14. Command");
            // Encapsulate a request as an object, thereby letting you parameterize clients with different requests,
            // queue or log requests, and support undoable operations. 
            Console.WriteLine("------------------------------------");
            ControlFourteen command = new ControlFourteen();
            command.Run();
            Console.WriteLine("------------------------------------");

            // 15. Interpreter
            // https://www.dofactory.com/net/interpreter-design-pattern
            Console.WriteLine("15. Interpreter");
            // Given a language, define a representation for its grammar along with an interpreter that uses the
            // representation to interpret sentences in the language. 
            Console.WriteLine("------------------------------------");
            ControlFifteen interpreter = new ControlFifteen();
            interpreter.Run();
            Console.WriteLine("------------------------------------");

            // 16. Iterator
            // https://www.dofactory.com/net/iterator-design-pattern
            Console.WriteLine("16. Iterator");
            // Provide a way to access the elements of an aggregate object sequentially without
            // exposing its underlying representation. 
            Console.WriteLine("------------------------------------");
            ControlSixteen iterator = new ControlSixteen();
            iterator.Run();
            Console.WriteLine("------------------------------------");

            // 17. Mediator
            // https://www.dofactory.com/net/mediator-design-pattern
            Console.WriteLine("17. Mediator");
            // Define an object that encapsulates how a set of objects interact.
            // Mediator promotes loose coupling by keeping objects from referring to each other explicitly,
            // and it lets you vary their interaction independently. 
            Console.WriteLine("------------------------------------");
            ControlSeventeen mediator = new ControlSeventeen();
            mediator.Run();
            Console.WriteLine("------------------------------------");

            // 18. Memento
            // https://www.dofactory.com/net/memento-design-pattern
            Console.WriteLine("18. Memento");
            // Without violating encapsulation, capture and externalize an object's internal state so that the object
            // can be restored to this state later. 
            Console.WriteLine("------------------------------------");
            ControlEigthteen memento = new ControlEigthteen();
            memento.Run();
            Console.WriteLine("------------------------------------");

            // 19. Observer
            // https://www.dofactory.com/net/observer-design-pattern
            Console.WriteLine("19. Observer");
            // Define a one-to-many dependency between objects so that when one object changes state, all its dependents
            // are notified and updated automatically. 
            Console.WriteLine("------------------------------------");
            ControlNineteen observer = new ControlNineteen();
            observer.Run();
            Console.WriteLine("------------------------------------");

            // 20. State
            // https://www.dofactory.com/net/state-design-pattern
            Console.WriteLine("20. State");
            // Allow an object to alter its behavior when its internal state changes. The object will appear to change its class.  
            Console.WriteLine("------------------------------------");
            ControlTwenty state = new ControlTwenty();
            state.Run();
            Console.WriteLine("------------------------------------");

            // 21. Strategy
            // https://www.dofactory.com/net/strategy-design-pattern
            Console.WriteLine("21. Strategy");
            // Define a family of algorithms, encapsulate each one, and make them interchangeable.
            // Strategy lets the algorithm vary independently from clients that use it.  
            Console.WriteLine("------------------------------------");
            ControlTwentyone strategy = new ControlTwentyone();
            strategy.Run();
            Console.WriteLine("------------------------------------");

            // 22. Template
            // https://www.dofactory.com/net/template-method-design-pattern
            Console.WriteLine("22. Template");
            // Define the skeleton of an algorithm in an operation, deferring some steps to subclasses.
            // Template Method lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure. 
            Console.WriteLine("------------------------------------");
            ControlTwentytwo template = new ControlTwentytwo();
            template.Run();
            Console.WriteLine("------------------------------------");

            // 23. Visitor
            // https://www.dofactory.com/net/visitor-design-pattern
            Console.WriteLine("23. Visitor");
            // Represent an operation to be performed on the elements of an object structure.
            // Visitor lets you define a new operation without changing the classes of the elements on which it operates. 
            Console.WriteLine("------------------------------------");
            ControlTwentythree visitor = new ControlTwentythree();
            visitor.Run();
            Console.WriteLine("------------------------------------");
        }
    }
}

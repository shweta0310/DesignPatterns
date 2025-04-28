// See https://aka.ms/new-console-template for more information
using DesignPatterns.AbstractFactoryPattern;
using DesignPatterns.AdapterPattern;
using DesignPatterns.BuilderPattern;
using DesignPatterns.CommandPattern;
using DesignPatterns.CompositePattern;
using DesignPatterns.DecoratorPattern;
using DesignPatterns.FacadePattern;
using DesignPatterns.FactoryMethodPattern;
using DesignPatterns.IteratorPattern;
using DesignPatterns.ObserverPattern;
using DesignPatterns.SingletonPattern;
using DesignPatterns.StatePattern;
using DesignPatterns.StrategyPattern;
using DesignPatterns.TemplateMethodPattern;

Console.WriteLine("Select a design pattern to run:\n" +
    "1. Strategy Pattern\n" +
    "2. Observer Pattern\n" +
    "3. Decorator Pattern\n" +
    "4. Factory Method Pattern\n" +
    "5. Abstract Factory Pattern\n" +
    "6. Singleton Pattern\n" +
    "7. Command Pattern\n" +
    "8. Adapter Pattern\n" +
    "9. Facade Pattern\n" +
    "10. Template Method Pattern\n" +
    "11. Iterator Pattern\n" +
    "12. Composite Pattern\n" +
    "13. State Pattern\n" +
    "14. Builder Pattern\n"
    );
var choice = Console.ReadLine();

switch (choice)
{
    case "1":
        StrategyPattern strategyPattern = new();
        strategyPattern.RunPattern();
        break;
    case "2":
        ObserverPattern observerPattern = new();
        observerPattern.RunPattern();
        break;
    case "3":
        DecoratorPattern.RunPattern();
        break;
    case "4":
        FactoryMethodPattern.RunPattern();
        break;
    case "5":
        AbstractFactoryPattern.RunPattern();
        break;
    case "6":
        SingletonPattern.RunPattern();
        break;
    case "7":
        CommandPattern.RunPattern();
        break;
    case "8":
        AdapterPattern.RunPattern();
        break;
    case "9":
        FacadePattern.RunPattern();
        break;
    case "10":
        TemplateMethodPattern.RunPattern();
        break;
    case "11":
        IteratorPattern.RunPattern();
        break;
    case "12":
        CompositePattern.RunPattern();
        break;
    case "13":
        StatePattern.RunPattern();
        break;
    case "14":
        BuilderPattern.RunPattern();
        break;
    default:
        Console.WriteLine("Invalid choice.");
        break;
}


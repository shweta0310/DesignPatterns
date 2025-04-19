namespace DesignPatterns.FactoryMethodPattern
{
    internal class FactoryMethodPattern
    {
        public static void RunPattern()
        {
            IPersonFactory personFactory = new PersonFactory();
            IPerson person1 = personFactory.CreatePerson("John Doe");
            IPerson person2 = personFactory.CreatePerson("Jane Doe");
            IPerson person3 = personFactory.CreatePerson("John Smith");
            Console.WriteLine($"Person 1: {person1.Id} - {person1.Name}");
            Console.WriteLine($"Person 2: {person2.Id} - {person2.Name}");
            Console.WriteLine($"Person 3: {person3.Id} - {person3.Name}");
        }
    }
}

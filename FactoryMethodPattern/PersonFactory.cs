namespace DesignPatterns.FactoryMethodPattern
{
    internal interface IPersonFactory
    {
        public IPerson CreatePerson(string name);
    }

    internal class PersonFactory : IPersonFactory
    {
        public int PersonNumber { get; set; } = 0;
        public IPerson CreatePerson(string name)
        {
            return new Person(PersonNumber++, name);
        }
    }
}

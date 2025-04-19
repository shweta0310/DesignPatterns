namespace DesignPatterns.FactoryMethodPattern
{
    internal interface IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    internal class Person : IPerson
    {
        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

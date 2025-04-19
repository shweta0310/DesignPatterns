namespace DesignPatterns.CompositePattern
{
    internal class Directory : FileSystemComponent
    {
        public List<FileSystemComponent> Components { get; set; }
        public Directory(string name)
        {
            Name = name;
            Components = new List<FileSystemComponent>();
        }

        public override void Display(int indentationLevel)
        {
            Console.WriteLine(new string('\t', indentationLevel) + $"Directory: {Name} Size: {GetSize()}");
            foreach (var component in Components)
            {
                component.Display(indentationLevel + 1);
            }
        }
        public override int GetSize()
        {
            return Components.Sum(c => c.GetSize());
        }
        public List<FileSystemComponent> ListContents()
        {
            return Components;
        }
        public void Add(FileSystemComponent component)
        {
            if (Components.Any(c => c.Name == component.Name))
                throw new InvalidOperationException($"Component with name {component.Name} already exists in the directory.");

            if (component.Parent != null)
                component.Parent.Remove(component);

            Components.Add(component);
            component.Parent = this;
        }
        public void Remove(FileSystemComponent component)
        {
            Components.Remove(component);
            component.Parent = null;
        }
        public FileSystemComponent GetChild(int index)
        {
            if (index < 0 || index >= Components.Count)
                throw new ArgumentOutOfRangeException("Index out of range.");
            return Components[index];
        }

        public FileSystemComponent? SearchByName(string targetName)
        {
            if (Name == targetName)
                return this;
            foreach (var component in Components)
            {
                if (component is Directory directory)
                {
                    var found = directory.SearchByName(targetName);
                    if (found != null)
                        return found;
                }
                else if (component.Name == targetName)
                {
                    return component;
                }
            }
            return null;
        }

        // Use Action<T> to apply a function to each component
        public void ApplyRecursive(Action<FileSystemComponent> action)
        {
            action(this);

            foreach (var child in Components)
            {
                if (child is Directory dir)
                    dir.ApplyRecursive(action);
                else
                {
                    action(child);
                }
            }
        }
    }
}

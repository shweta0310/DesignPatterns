namespace DesignPatterns.CompositePattern
{
    internal abstract class FileSystemComponent
    {
        public string? Name { get; set; }
        public Directory? Parent { get; set; }
        public abstract void Display(int indentationLevel);
        public abstract int GetSize();
        public void MoveTo(Directory newParent)
        {
            if (Parent != null)
                Parent.Remove(this);
            newParent.Add(this);
            Parent = newParent;
        }
    }
}

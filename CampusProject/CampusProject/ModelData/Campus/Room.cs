public sealed class Room : ModelObject
{
    public string Name { get; }

    public Room(IModel model, Guid id, string name) : base(model, id)
    {
        Name = name;
    }

    public override string ToString()
    {
        return Name;
    }
}
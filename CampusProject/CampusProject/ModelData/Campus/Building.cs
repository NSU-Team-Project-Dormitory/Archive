public sealed class Building : ModelObject
{
    public string Name { get; }
    public IReadOnlyDictionary<Guid, Floor> Floors { get; }

    public Building(IModel model, Guid id,
        string name, IReadOnlyDictionary<Guid, Floor> floors) : base(model, id)
    {
        Name = name;
        Floors = floors;
    }

    public override string ToString()
    {
        string buildingInfo = Name + "\n";

        foreach (var floor in Floors)
        {
            buildingInfo += floor.Value.ToString() + "\n";
        }

        return buildingInfo;
    }
}
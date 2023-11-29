public sealed class Campus 
{
    public string Name { get; }
    public IReadOnlyDictionary<Guid, Building> Buildings { get; }

    public Campus(string name, IReadOnlyDictionary<Guid, Building> buildings)
    {
        Name = name;
        Buildings = buildings;
    }

    public override string ToString()
    {
        string campusInfo = Name + "\n";

        foreach (var building in Buildings)
        {
            campusInfo += building.Value.ToString() + "\n";
        }

        return campusInfo;
    }
}
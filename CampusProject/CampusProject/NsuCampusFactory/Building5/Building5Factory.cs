public sealed class Building5Factory
{
    private readonly CampusModel _model;

    public Building5Factory(CampusModel model)
    {
        _model = model;
    }
    public Building Create()
    {
        var floors = new Dictionary<Guid, Floor>();
        var firstFloor = new Building5FirstFloorFactory(_model).Create();

        floors.Add(firstFloor.Id, firstFloor);
        
        var building = new Building(_model, new Guid("{C52285D0-6164-410E-83A2-BC4C2001191D}"),
            "Общежитие 5", floors);

        return building;
    }
}
using System.Collections.ObjectModel;

public sealed class NsuBuildingsFactory
{
    private readonly CampusModel _model;

    public NsuBuildingsFactory(CampusModel model)
    {
        _model = model;
    }
    public IReadOnlyDictionary<Guid, Building> CreateBuildings()
    {
        var buildings = new Dictionary<Guid, Building>();

        var hostel4 = new Building4Factory(_model).Create();
        var hostel5 = new Building5Factory(_model).Create();
        var hostel7 = new Building7Factory(_model).Create();

        buildings.Add(hostel4.Id, hostel4);
        buildings.Add(hostel5.Id, hostel5);
        buildings.Add(hostel7.Id, hostel7);

        return buildings;
    }
}
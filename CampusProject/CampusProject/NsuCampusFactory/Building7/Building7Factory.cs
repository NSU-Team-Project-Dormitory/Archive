public sealed class Building7Factory
{
    private readonly CampusModel _model;

    public Building7Factory(CampusModel model)
    {
        _model = model;
    }
    public Building Create()
    {
        var building = new Building(_model, new Guid("{E2027333-0E34-4B70-B52F-235F13A8353E}"),
            "Общежитие 7", new Dictionary<Guid, Floor>());

        return building;
    }
}
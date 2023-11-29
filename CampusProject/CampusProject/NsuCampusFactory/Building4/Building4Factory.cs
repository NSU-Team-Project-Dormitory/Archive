public sealed class Building4Factory
{
    private readonly CampusModel _model;

    public Building4Factory(CampusModel model)
    {
        _model = model;
    }
    public Building Create()
    {

        var building = new Building(_model, new Guid("{975D3C53-CF01-40E5-BD35-BE42C0DE271F}"),
            "Общежитие 4", new Dictionary<Guid, Floor>());

        return building;
    }
}
public sealed class NsuCampusFactory
{
    private readonly CampusModel _model;

    public NsuCampusFactory(CampusModel model)
    {
        _model = model;
    }

    public Campus Create()
    {
        var buildingsFactory = new NsuBuildingsFactory(_model);

        var campus = new Campus(_model, new Guid("{53545CD5-35B6-41D7-9BD9-D0228AA8511E}"),
            "НГУ", buildingsFactory.CreateBuildings());

        return campus;
    }
}
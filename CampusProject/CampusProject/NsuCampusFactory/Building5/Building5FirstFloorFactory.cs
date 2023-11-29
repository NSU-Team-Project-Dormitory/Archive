public sealed class Building5FirstFloorFactory
{
    private readonly CampusModel _model;

    public Building5FirstFloorFactory(CampusModel model)
    {
        _model = model;
    }

    public Floor Create()
    {
        var rooms = new Dictionary<Guid, Room>();

        var room101s = new Room(_model, new Guid("{40E8B141-F09F-4BE8-A7B5-318A6D87E62D}"),
            "101м");
        var room101b = new Room(_model, new Guid("{2B1D3104-3088-4467-B97D-37C726870082}"),
            "101б");
        var room102 = new Room(_model, new Guid("{BA288027-A368-434D-A815-62CF62A56C79}"),
            "102");
        var room103 = new Room(_model, new Guid("{A9C64CE5-A2E5-4304-85C4-4F6F55A786C8}"),
            "103");

        rooms.Add(room101s.Id, room101s);
        rooms.Add(room101b.Id, room101b);
        rooms.Add(room102.Id, room102);
        rooms.Add(room103.Id, room103);

        return new Floor(_model, new Guid("{DD656AAB-EFC8-4E35-947B-89284E781A6B}")
            , "Этаж 1", rooms);
    }
}
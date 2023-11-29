public sealed class CampusModel : IModel
{
    public Campus Campus { get; }
    public CheckInBook CheckInBook { get; }
    public CitizenBook CitizenBook { get; }

    public CampusModel(Campus campus, CheckInBook checkInBook, CitizenBook citizenBook)
    {
        Campus = campus;
        CheckInBook = checkInBook;
        CitizenBook = citizenBook;
    }
}
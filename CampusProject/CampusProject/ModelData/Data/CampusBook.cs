public sealed class CampusBook
{
    public PersonDocument Document { get; }
    public string CampusBookId { get; }

    public CampusBook(PersonDocument document, string campusBookId)
    {
        Document = document;
        CampusBookId = campusBookId;
    }
}
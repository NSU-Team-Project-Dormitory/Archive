public sealed class PersonDocument
{
    public string LastName { get; }
    public string Name { get; }
    public string Surname { get; }
    public string DocumentType { get; }
    public string DocumentId { get; }

    public PersonDocument(string lastName, 
        string name,
        string surname,
        string documentType,
        string documentId)
    {
        LastName = lastName;
        Name = name;
        Surname = surname;
        DocumentType = documentType;
        DocumentId = documentId;
    }
}
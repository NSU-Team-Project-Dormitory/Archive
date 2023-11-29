public class Citizen : Person
{
    public PersonDocument Document { get; }

    public Citizen(IModel model, Guid id, PersonDocument document) : base(model, id)
    {
        Document = document;
    }
}
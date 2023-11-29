public sealed class Student : Citizen
{
    public Student(IModel model, Guid id, CampusBook document)
        : base(model, id, document.Document)
    {
    }
}
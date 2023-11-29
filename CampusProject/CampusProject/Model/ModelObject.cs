public class ModelObject
{
    public IModel Model { get; }
    public Guid Id { get; }

    public ModelObject(IModel model, Guid id)
    {
        Model = model;
        Id = id;
    }
}
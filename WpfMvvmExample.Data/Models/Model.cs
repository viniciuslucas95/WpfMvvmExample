namespace WpfMvvmExample.Data.Models;

public class Model
{
    public Guid Id { get; private init; }

    public Model()
    {
        Id = Guid.NewGuid();
    }
}

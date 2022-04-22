namespace MapsterPoc.Domain;

public class Client
{
    public int Id { get; set; }
    public Name Name { get; }
    public DateOnly DateOfBirth { get; set; }

    public Client(string lastName)
    {
        this.Name = new Name(lastName);
    }
}

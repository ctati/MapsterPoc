namespace MapsterPoc.Domain;

public class Person
{
    public int Id { get; set; }
    public Name Name { get; }
    public DateOnly DateOfBirth { get; set; }

    public Person(string lastName)
    {
        Name = new Name(lastName);
    }
}

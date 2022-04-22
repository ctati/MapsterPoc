namespace MapsterPoc.Domain;

public class Name
{
    public string? FirstName { get; set; }
    public string LastName { get; }
    public string? Suffix { get; set; }

    public Name(string lastName)
    {
        this.LastName = lastName;
    }
}
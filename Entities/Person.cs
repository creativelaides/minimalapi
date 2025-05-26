namespace minimalapi.Entities;

public class Person
{
    public int Id { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string? Email { get; set; }

    public string FullName()
    {
        return $"{FirstName} {LastName}";
    }

    public override string ToString()
    {
        return $"{Id}: {FullName()} ({Email})";
    }
}
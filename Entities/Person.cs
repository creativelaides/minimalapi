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
        return $"{Id}: {FirstName} {LastName} ({Email})";
    }

    public override bool Equals(object? obj)
    {
        if (obj is not Person other)
            return false;

        return Id == other.Id &&
               FirstName == other.FirstName &&
               LastName == other.LastName &&
               Email == other.Email;
    }

    public override int GetHashCode()
    {
        throw new NotImplementedException();
    }
}
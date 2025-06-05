using minimalapi.Entities.ValueObjects;

namespace minimalapi.Entities;

public class Person(int id, string firstName, string lastName, string email)
{
    public int Id { get; set; } = id;
    public required string FirstName { get; set; } = firstName;
    public required string LastName { get; set; } = lastName;
    public string? Email { get; set; } = email;

    public Phone? Phone { get; set; }
    public Address? Address { get; set; }

    public string FullName()
    {
        return $"{FirstName} {LastName}";
    }

    public override string ToString()
    {
        return $"{Id}: {FullName()} ({Email})";

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
        return HashCode.Combine(Id, FirstName, LastName, Email);
    }
}
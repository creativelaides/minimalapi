namespace minimalapi.Entities.ValueObjects;

public record Phone
{
    public int Id { get; set; }
    public required string Number { get; set; }
    public required string Type { get; set; } // e.g., "Mobile", "Home", "Work"

    public override string ToString()
    {
        return $"{Id}: {Number} ({Type})";
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id, Number, Type);
    }
}
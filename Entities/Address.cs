namespace minimalapi.Entities;

public record Address
{
    public int Id { get; set; }
    public required string Street { get; set; }
    public required string City { get; set; }
    public required string State { get; set; }
    public required string ZipCode { get; set; }

    public override string ToString()
    {
        return $"{Id}: {Street}, {City}, {State} {ZipCode}";
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id, Street, City, State, ZipCode);
    }
}
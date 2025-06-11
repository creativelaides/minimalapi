namespace minimalapi.Entities.ValueObjects;

public record Location
{
    public int Id { get; set; }
    public required string Address { get; set; }
    public required string City { get; set; }
    public required string State { get; set; }
    public required string ZipCode { get; set; }

    public override string ToString()
    {
        return $"{Id}: {Address}, {City}, {State} {ZipCode}";
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Id, Address, City, State, ZipCode);
    }
}

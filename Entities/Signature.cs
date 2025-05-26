namespace minimalapi.Entities;

public class Signature
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }
    public string? Category { get; set; }


    //TODO: Implement validation logic
    public void Validate()
    {
        throw new NotImplementedException("Validation logic is not implemented yet.");
    }

    //TODO: Implement a method to convert the signature to a string representation
    public override string ToString()
    {
        throw new NotImplementedException("Conversion logic is not implemented yet.");
    }
}
namespace minimalapi.Entities;

public class Signature
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? ImageUrl { get; set; }
    public string? Category { get; set; }


    public void Validate()
    {
        if (string.IsNullOrWhiteSpace(Name))
        {
            throw new ArgumentException("Name cannot be null or empty.", nameof(Name));
        }

        if (string.IsNullOrWhiteSpace(Description))
        {
            throw new ArgumentException("Description cannot be null or empty.", nameof(Description));
        }

        if (string.IsNullOrWhiteSpace(Category))
        {
            throw new ArgumentException("Category cannot be null or empty.", nameof(Category));
        }
    }

    public override string ToString()
    {
        return $"Signature: {Name}, Description: {Description}, Category: {Category}";
    }
}

namespace minimalapi.Entities;

public class Vehicle(string vim, string make, Person owner, string model, int year)
{
    public string Vim { get; set; } = vim;
    public string Make { get; set; } = make;
    public Person Owner { get; set; } = owner;

    public string Model { get; set; } = model;
    public int Year { get; set; } = year;
    
    public override string ToString()
    {
        return $"{Year} {Make} {Model} ({Vim}) owned by {Owner.FirstName} {Owner.LastName}";
    }
}

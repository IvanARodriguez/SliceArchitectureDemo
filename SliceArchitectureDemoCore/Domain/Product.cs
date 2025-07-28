namespace SliceArchitectureDemoCore.Domain;

public class Product
{
  public int Id { get; set; }
  public required string Name { get; set; }
  public string? Description { get; set; } = "";
  public required float Price { get; set; }
  public int CategoryId { get; set; }
  public Category? Category { get; set; }
}
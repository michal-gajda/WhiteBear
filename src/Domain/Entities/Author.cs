namespace WhiteBear.Domain.Entities;

public sealed record class Author
{
    public required int Id { get; init; }
    public required string Name { get; init; }
}

namespace WhiteBear.Application.Commands;

public sealed record class AddBook : IRequest
{
    public required string Isbn { get; init; }
    public required string Title { get; init; }
}

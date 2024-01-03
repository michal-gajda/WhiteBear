namespace WhiteBear.Domain.Interfaces;

using WhiteBear.Domain.Entities;

public interface IBookRepository
{
    Task CreateAsync(BookEntity entity, CancellationToken cancellationToken = default);
}

namespace WhiteBear.Infrastructure.Services;

using WhiteBear.Domain.Entities;
using WhiteBear.Domain.Interfaces;

internal sealed class BookRepository : IBookRepository
{
    public Task CreateAsync(BookEntity entity, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}

using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PackIT.Application.DTO;
using PackIT.Application.Queries;
using PackIT.Infrastructure.EF.Contexts;
using PackIT.Infrastructure.EF.Models;
using PackIT.Shared.Abstractions.Queries;

namespace PackIT.Infrastructure.Queries.Handlers
{
    internal sealed class GetPackingListHandler : IQueryHandler<GetPackingList, PackingListDto>
    {
        private readonly DbSet<PackingListReadModel> _packingList;

        public GetPackingListHandler(ReadDbContext context) => _packingList = context.PackingLists;

        public async Task<PackingListDto> HandleAsync(GetPackingList query)
            => await _packingList
                .Include(pl => pl.Items)
                .Where(pl => pl.Id == query.Id)
                .Select(pl => pl.AsDto())
                .AsNoTracking()
                .SingleOrDefaultAsync();
    }
}
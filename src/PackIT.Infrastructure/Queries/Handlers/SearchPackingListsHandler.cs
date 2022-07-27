using System.Collections.Generic;
using System.Threading.Tasks;
using PackIT.Application.DTO;
using PackIT.Application.Queries;
using PackIT.Shared.Abstractions.Queries;

namespace PackIT.Infrastructure.Queries.Handlers
{
public class SearchPackingListsHandler:IQueryHandler<SearchPackingLists, IEnumerable<PackingListDto>>
{
    public async Task<IEnumerable<PackingListDto>> HandleAsync(SearchPackingLists query)
    {
        throw new System.NotImplementedException();
    }
}
}
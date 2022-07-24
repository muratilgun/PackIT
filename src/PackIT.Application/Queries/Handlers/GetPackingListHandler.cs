using System.Threading.Tasks;
using PackIT.Application.DTO;
using PackIT.Shared.Abstractions.Queries;

namespace PackIT.Application.Queries.Handlers
{
    public class GetPackingListHandler : IQueryHandler<GetPackingList,PackingListDto>
    {
        public Task<PackingListDto> HandleAsync(GetPackingList query)
        {
            throw new System.NotImplementedException();
        }
    }
}
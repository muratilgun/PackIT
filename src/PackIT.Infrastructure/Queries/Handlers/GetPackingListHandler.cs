using System.Threading.Tasks;
using PackIT.Application.DTO;
using PackIT.Application.Queries;
using PackIT.Shared.Abstractions.Queries;
using PackingListDto = PackIT.Infrastructure.EF.Models.PackingListDto;

namespace PackIT.Infrastructure.Queries.Handlers
{
    public class GetPackingListHandler : IQueryHandler<GetPackingList,PackingListDto>
    {
        public async Task<PackingListDto> HandleAsync(GetPackingList query)
        {
            throw new System.NotImplementedException();
        }
    }
}
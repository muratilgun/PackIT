using System.Threading.Tasks;
using PackIT.Domain.Entities;
using PackIT.Domain.ValueObjects;

namespace PackIT.Domain.Repositories
{
    public interface IPackingListRepository
    {
        Task<PackingList> GetAsync(PackingListId id);
        Task<PackingList> AddAsync(PackingListId packingList);
        Task<PackingList> UpdateAsync(PackingListId packingList);
        Task<PackingList> DeleteAsync(PackingListId packingList);
    }
}
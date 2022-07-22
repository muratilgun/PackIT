using System.Threading.Tasks;
using PackIT.Domain.Entities;
using PackIT.Domain.ValueObjects;

namespace PackIT.Domain.Repositories
{
    public interface IPackingListRepository
    {
        Task<PackingList> GetAsync(PackingListId id);
        Task<PackingList> AddAsync(PackingList packingList);
        Task<PackingList> UpdateAsync(PackingList packingList);
        Task<PackingList> DeleteAsync(PackingList packingList);
    }
}
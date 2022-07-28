using System.Threading.Tasks;
using PackIT.Domain.Entities;
using PackIT.Domain.Repositories;
using PackIT.Domain.ValueObjects;

namespace PackIT.Infrastructure.EF.Repositories
{
    internal sealed class PostgresPackingListRepository : IPackingListRepository
    {
        public async Task<PackingList> GetAsync(PackingListId id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<PackingList> AddAsync(PackingList packingList)
        {
            throw new System.NotImplementedException();
        }

        public async Task<PackingList> UpdateAsync(PackingList packingList)
        {
            throw new System.NotImplementedException();
        }

        public async Task<PackingList> DeleteAsync(PackingList packingList)
        {
            throw new System.NotImplementedException();
        }
    }
}
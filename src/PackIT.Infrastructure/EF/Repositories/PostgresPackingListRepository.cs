﻿using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PackIT.Domain.Entities;
using PackIT.Domain.Repositories;
using PackIT.Domain.ValueObjects;
using PackIT.Infrastructure.EF.Contexts;

namespace PackIT.Infrastructure.EF.Repositories
{
    internal sealed class PostgresPackingListRepository : IPackingListRepository
    {
        private readonly DbSet<PackingList> _packingLists;
        private readonly WriteDbContext _writeDbContext;

        public PostgresPackingListRepository(DbSet<PackingList> packingLists, WriteDbContext writeDbContext)
        {
            _packingLists = packingLists;
            _writeDbContext = writeDbContext;
        }

        public async Task<PackingList> GetAsync(PackingListId id) => await _packingLists.Include("_items").SingleOrDefaultAsync(pl => pl.Id == id);

        public async Task AddAsync(PackingList packingList)
        {
            await _packingLists.AddAsync(packingList);
            await _writeDbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(PackingList packingList)
        {
            _packingLists.Update(packingList);
            await _writeDbContext.SaveChangesAsync();

        }

        public async Task DeleteAsync(PackingList packingList)
        {
             _packingLists.Remove(packingList);
            await _writeDbContext.SaveChangesAsync();
        }
    }
}
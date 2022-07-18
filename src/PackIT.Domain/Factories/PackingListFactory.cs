using PackIT.Domain.Consts;
using PackIT.Domain.Entities;
using PackIT.Domain.ValueObjects;

namespace PackIT.Domain.Factories
{
    class PackingListFactory : IPackingListFactory
    {
        public PackingList Create(PackingListId id, PackingListName name, Localization localization)
        {
            throw new System.NotImplementedException();
        }

        public PackingList CreateWithDefaultItem(PackingListId id, PackingListName name, TravelDays days, Gender gender,
            Localization localization)
        {
            throw new System.NotImplementedException();
        }
    }
}
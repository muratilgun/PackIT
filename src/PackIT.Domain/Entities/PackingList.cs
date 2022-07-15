using System;
using System.Collections.Generic;
using System.Linq;
using PackIT.Domain.Exceptions;
using PackIT.Domain.ValueObjects;

namespace PackIT.Domain.Entities
{
    public class PackingList
    {
        public Guid Id { get; private set; }

        private PackingListName _name;
        private Localization _localization;
        private readonly LinkedList<PackingItem> _items= new();

        internal PackingList(Guid id, PackingListName name, Localization localization)
        {
            Id = id;
            _name = name;
            _localization = localization;
        }

        public void AddItem(PackingItem item)
        {
            var alreadyExists = _items.Any(i => i.Name == item.Name);
            if (alreadyExists)
            {
                throw new PackingItemAlreadyExistsException(_name, item.Name);
            }

            _items.AddLast(item);
        }
    }
}
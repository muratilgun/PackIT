﻿using PackIT.Shared.Abstractions.Exceptions;

namespace PackIT.Domain.Exceptions
{
    public class PackingItemNotFoundException : PackItException
    {
        public string ItemName { get; }
        public PackingItemNotFoundException(string itemName) 
            : base($"Packing item '{itemName}' vas not found.")
            => ItemName = itemName;
    }
}
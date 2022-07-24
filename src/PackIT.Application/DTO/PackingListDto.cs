﻿using System;
using System.Collections.Generic;
using PackIT.Domain.ValueObjects;

namespace PackIT.Application.DTO
{
    public class PackingListDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Localization Localization { get; set; }
        public IEnumerable<PackingItemDto> Items { get; set; }
    }
}
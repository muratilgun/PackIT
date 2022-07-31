﻿using System;
using System.Collections.Generic;

namespace PackIT.Infrastructure.EF.Models
{
    internal class PackingListReadModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Version { get; set; }
        public LocalizationReadModel Localization { get; set; }
        public ICollection<Infrastructure.EF.Models.PackingItemReadModel> Items { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Item
    {
        public int ItemId { get; set; }
        public int ItemTypeId { get; set; }
        public string ItemName { get; set; }

        //References
        public ItemType ItemType { get; set; }

    }
}
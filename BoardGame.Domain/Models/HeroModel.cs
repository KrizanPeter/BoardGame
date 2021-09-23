﻿using BoardGame.Domain.Entities.EntityEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGame.Domain.Models
{
    public class HeroModel
    {
        public int HeroId { get; set; }
        public int BlockId { get; set; }
        public int AppUserId { get; set; }
        public int HeroTypeId { get; set; }
        public string HeroName { get; set; }
        public HeroType HeroType { get; set; }
        public string ImagePath { get; set; }
        public int Lives { get; set; }
    }
}

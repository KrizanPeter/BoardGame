﻿using BoardGame.Domain.Entities.EntityEnums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoardGame.Domain.Models
{
    public class BlockModel
    {
        public int BlockId { get; set; }
        public int SessionId { get; set; }
        public int? MonsterId { get; set; }
        public int BlockPositionX { get; set; }
        public int BlockPositionY { get; set; }
        public BlockType BlockType { get; set; }
        public BlockDirection BlockDirection { get; set; }
    }
}

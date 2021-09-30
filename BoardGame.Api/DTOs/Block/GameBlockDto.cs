﻿using System.Collections.Generic;

using BoardGame.Api.DTOs.Hero;
using BoardGame.Domain.Entities.EntityEnums;

namespace BoardGame.Api.DTOs.Block
{
    public class GameBlockDto
    {
        public int BlockId { get; set; }
        public int SessionId { get; set; }
        public int? MonsterId { get; set; }
        public int BlockPositionX { get; set; }
        public int BlockPositionY { get; set; }
        public int BlockOrder { get; set; }
        public string ImagePath { get; set; }

        public BlockType BlockType { get; set; }
        public BlockDirection BlockDirection { get; set; }

        public ICollection<GameHeroDto> Heroes { get; set; }

    }
}

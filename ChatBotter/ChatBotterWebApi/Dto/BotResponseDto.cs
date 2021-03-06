﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChatBotterWebApi.DTO
{
    public class BotResponseDto
    {
        public int Id { get; set; }

        [Required]
        public int Priority { get; set; }

        [Required]
        public string ResponseText { get; set; }

        [Required]
        public int TheProjectId { get; set; }

        [Required]
        public int PatternId { get; set; }
    }
}

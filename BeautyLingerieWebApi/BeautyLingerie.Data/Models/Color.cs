﻿using BeautyLingerie.Common;
using System.ComponentModel.DataAnnotations;

namespace BeautyLingerie.Data.Models
{
    public class Color
    {
        public Color()
        {
            ColorId = Guid.NewGuid();
        }
        [Key]
        public Guid ColorId { get; set; }

        [Required]
        [MaxLength(ValidationalConstants.ColorNameMaxSize)]
        public string Name { get; set; } = null!;
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GoingTo_API.Resources
{
    public class SaveLanguageResource
    {
        [Required]
        [MaxLength(45)]
        public string ShortName { get; set; }
        [Required]
        [MaxLength(45)]
        public string FullName { get; set; }
    }
}

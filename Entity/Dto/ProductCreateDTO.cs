﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dto
{
    public class ProductCreateDTO
    {
        public string? Title { get; set; }
        public double Price { get; set; }
        public string? ImageName { get; set; }
    }
}

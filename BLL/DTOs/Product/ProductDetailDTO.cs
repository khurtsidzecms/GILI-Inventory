﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTOs.Product
{
    public class ProductDetailDTO
    {

        public int Id { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        public string Brand { get; set; }

        public DateTime ImportDate { get; set; }
    }
}

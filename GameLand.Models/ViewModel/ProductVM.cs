﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLand.Models.ViewModel
{
    public class ProductVM
    {
        public Product Product { get; set; }
        public IEnumerable <SelectListItem> CategoryList { get; set; }
    }
}
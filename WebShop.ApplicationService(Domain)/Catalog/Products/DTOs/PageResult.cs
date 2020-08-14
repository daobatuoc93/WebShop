﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop.ApplicationService_Domain_.Catalog.Products.DTOs
{
    public class PageResult<T>
    {
        public List<T> Items { get; set; }
        public int TotalRecord { get; set; }
    }
}

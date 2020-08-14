using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop.ApplicationService_Domain_.Catalog.Products.DTOs
{
    public class PagingRequestBase
    {
        public int pageIndex { get; set; }
        public int pageSize { get; set; }
    }
}

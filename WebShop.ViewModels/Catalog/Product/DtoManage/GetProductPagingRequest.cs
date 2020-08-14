using System.Collections.Generic;
using WebShop.ViewModels.Catalog.Common;

namespace WebShop.ViewModels.Catalog.Product.DtoManage
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public string keyWord { get; set; }
        public List<int> CategoryId { get; set; }
    }
}

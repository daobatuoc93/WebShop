using System.Collections.Generic;
using System.Text;
using WebShop.ApplicationService_Domain_.DataTransferObjects;
namespace WebShop.ApplicationService_Domain_.Catalog.Products.DataTransferObjects.DtoManage
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public string keyWord { get; set; }
        public List<int> CategoryId { get; set; }
    }
}

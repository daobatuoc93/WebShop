
using WebShop.ApplicationService_Domain_.Catalog.Products.DTOs;

namespace WebShop.ApplicationService_Domain_.Catalog.Products.DataTransferObjects.DtoPublic
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public int? CatagoryId { get; set; }

    }
}

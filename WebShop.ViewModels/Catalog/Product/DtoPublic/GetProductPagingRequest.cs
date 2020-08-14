using WebShop.ViewModels.Catalog.Common;

namespace WebShop.ViewModels.Catalog.Product.DtoPublic
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public int? CatagoryId { get; set; }

    }
}

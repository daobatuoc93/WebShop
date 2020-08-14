using System.Threading.Tasks;
using WebShop.ViewModels.Catalog.Common;
using WebShop.ViewModels.Catalog.Product;
using WebShop.ViewModels.Catalog.Product.DtoPublic;

namespace WebShop.ApplicationService_Domain_.Catalog.Products
{
    //just use for customer would like to read
    //when use Interface no public
    public interface IPublicProduct
    {
        Task<PageResult<ProductViewModel>> GetAllByCategoryId(GetProductPagingRequest request);
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebShop.ApplicationService_Domain_.Catalog.Products.DataTransferObjects;
using WebShop.ApplicationService_Domain_.Catalog.Products.DataTransferObjects.DtoManage;
using WebShop.ApplicationService_Domain_.DTOs;

namespace WebShop.ApplicationService_Domain_.Catalog
{
    public interface IManageProductService 
    {
        Task<int> Create(ProductCreateRequest request);
        Task<int> Update(ProductUpdateRequest request);
        Task<int> Delete(int productId);
        Task<PageResult<ProductViewModel>> GetAllPage(GetProductPagingRequest keyWord);
        Task<bool> UpdatePrice(int productID,decimal newPrice);
        Task AddViewCount(int productId);
        Task<bool> UpdateStock(int productId, int addQuantity);
    }
}

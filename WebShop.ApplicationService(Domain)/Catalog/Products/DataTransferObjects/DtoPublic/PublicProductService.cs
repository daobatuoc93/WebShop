using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.ApplicationService_Domain_.Catalog.Products.DTOs;
using WebShop.DATA.EF;

namespace WebShop.ApplicationService_Domain_.Catalog.Products.DataTransferObjects.DtoPublic
{

    public class PublicProductService : IPublicProduct
    {
        private readonly WebShopDbContext _context;
        public PublicProductService(WebShopDbContext context)
        {
            _context = context;
        }
        public async Task<PageResult<ProductViewModel>> GetAllByCategoryId(GetProductPagingRequest request)
        {
            //Select Join
            var productCategory = from product in _context.Products
                                  join pt in _context.ProductTranslations on product.Id equals pt.ProductId
                                  join pic in _context.ProductInCategories on product.Id equals pic.ProductId
                                  join c in _context.Categories on pic.CategoryId equals c.Id
                                  select new { product, pt, pic };
            //Filter
            if (request.CatagoryId.HasValue && request.CatagoryId.Value > 0)
                productCategory = productCategory.Where(p => p.pic.CategoryId == request.CatagoryId);
            //Paging
            int totalRow = await productCategory.CountAsync();
            
            //take pageSize
            var data = await productCategory.Skip((request.pageSize - 1) * request.pageSize)
                .Take(request.pageSize)
                .Select(p => new ProductViewModel()
                {
                    Id = p.product.Id,
                    Name = p.pt.Name,
                    DateCreated = p.product.DateCreated,
                    Details = p.pt.Details,
                    LanguageId = p.pt.LanguageId,
                    OriginalPrice = p.product.OriginalPrice,
                    Price = p.product.Price,
                    SeoAlias = p.pt.SeoAlias,
                    SeoDescription = p.pt.SeoDescription,
                    SeoTitle = p.pt.SeoTitle,
                    Stock = p.product.Stock,
                    ViewCount = p.product.ViewCount,
                })
                .ToListAsync();
            //4. Select and projection
            var pageResult = new PageResult<ProductViewModel>()
            {
                TotalRecord = totalRow,
                Items = data,
            };
            return pageResult;
        }

    }
}

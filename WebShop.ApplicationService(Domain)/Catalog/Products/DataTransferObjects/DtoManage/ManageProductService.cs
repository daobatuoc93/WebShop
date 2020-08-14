using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.ApplicationService_Domain_.Catalog.Products.DTOs;
using WebShop.DATA.EF;
using WebShop.DATA.Entity;
using WebShop.Utilities.Exceptions;

namespace WebShop.ApplicationService_Domain_.Catalog.Products.DataTransferObjects.DtoManage
{
    public class ManageProductService : IManageProductService
    {
        private readonly WebShopDbContext _context;
        public ManageProductService(WebShopDbContext context)
        {
            _context = context;
        }

        public async Task AddViewCount(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            product.ViewCount += 1;
            await _context.SaveChangesAsync();
        }

        public async Task<int> Create(ProductCreateRequest request)
        {
            var product = new Product()
            {
                Price = request.Price,
                OriginalPrice = request.OriginalPrice,
                Stock = request.Stock,
                ViewCount = 0,
                DateCreated = DateTime.Now,
                ProductTranslations = new List<ProductTranslation>()
                {
                    new ProductTranslation
                    {
                        Name = request.Name,
                        Description = request.Description,
                        Details = request.Details,
                        SeoAlias = request.SeoAlias,
                        SeoDescription = request.SeoDescription,
                        SeoTitle = request.SeoTitle,
                        LanguageId=request.LanguageId
                    }
                }
            };
            _context.Products.Add(product);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            if(product == null)
            {
                throw new WebShopException($"the {productId} is not existing! ");
            }
            _context.Products.Remove(product);
            return await _context.SaveChangesAsync();
        }
        public async Task<PageResult<ProductViewModel>> GetAllPage(GetProductPagingRequest request)
        {
            //1. Select join
            var query = from product in _context.Products
                        join pt in _context.ProductTranslations on product.Id equals pt.ProductId
                        join p in _context.ProductInCategories on product.Id equals p.ProductId
                        join c in _context.Categories on product.Id equals c.Id
                        select new { product, pt,p };
            //2.filter
            if (!string.IsNullOrEmpty(request.keyWord))
                query = query.Where(x => x.pt.Name.Contains(request.keyWord));
            if (request.CategoryId.Count > 0)
            {
                query = query.Where(x => request.CategoryId.Contains(x.p.CategoryId));
            }
            //3. Paging
            int totalRow = await query.CountAsync();
            //take pageSize
            var data = await query.Skip((request.pageIndex - 1) * request.pageSize)
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
                    Stock  = p.product.Stock,
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

        public async Task<int> Update(ProductUpdateRequest request)
        {
            var product = await _context.Products.FindAsync(request.Id);
            var producTranslations = await _context.ProductTranslations.FirstOrDefaultAsync(x => x.ProductId == request.Id
            && x.LanguageId == request.LanguageId);
            if (product == null)
                throw new WebShopException($"the Produc with {request.Id} is not existing to update translation! ");
            producTranslations.Name = request.Name;
            producTranslations.SeoAlias = request.SeoAlias;
            producTranslations.SeoDescription = request.SeoDescription;
            producTranslations.SeoTitle = request.SeoTitle;
            producTranslations.Description = request.Description;
            producTranslations.Details = request.Details;
            return await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdatePrice(int productID, decimal newPrice)
        {
            var product = await _context.Products.FindAsync(productID);            
            if (product == null)
            {
                throw new WebShopException($"the Produc with {productID} is not existing to update price!");
            }
            product.Price = newPrice;
            return await _context.SaveChangesAsync() > 0;
        }


        public async Task<bool> UpdateStock(int productId, int addQuantity)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product == null)
            {
                throw new WebShopException($"the Produc with {productId} is not existing to update price!");
            }
            product.Stock += addQuantity;
            return await _context.SaveChangesAsync() > 0;
        }
    }
}

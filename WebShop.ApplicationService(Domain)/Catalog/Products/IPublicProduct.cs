﻿using System;
using System.Collections.Generic;
using System.Text;
using WebShop.ApplicationService_Domain_.Catalog.Products.DTOs;
using System.Threading.Tasks;
using WebShop.ApplicationService_Domain_.Catalog.Products.DataTransferObjects;
using WebShop.ApplicationService_Domain_.Catalog.Products.DataTransferObjects.DtoPublic;

namespace WebShop.ApplicationService_Domain_.Catalog.Products
{
    //just use for customer would like to read
    //when use Interface no public
    public interface IPublicProduct
    {
        Task<PageResult<ProductViewModel>> GetAllByCategoryId(GetProductPagingRequest request);
    }
}

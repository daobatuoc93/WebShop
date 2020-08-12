using System;
using System.Collections.Generic;
using System.Text;

namespace WebShop.DATA.Entity
{
    public class ProductInCategory
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }//F:\eShopLearn\eShopProject\WebShop.DATA\Entity\ProductInCategory.cs
}

using System;
using System.Linq.Expressions;
using Core.Entities;

namespace Core.Specifications
{
    public class ProductsWithTypesAndBrandsSpecification : BaseSpecification<Product>
    {
        public ProductsWithTypesAndBrandsSpecification()
        {
            addInclude(x => x.ProductType);
            addInclude(x => x.ProductBrand);
        }

        public ProductsWithTypesAndBrandsSpecification(int id) 
        : base(x => x.Id == id)
        {
            addInclude(x => x.ProductType);
            addInclude(x => x.ProductBrand);
        }
    }
}
using Core.EFRepository;
using DAL.Abstracts;
using DAL.Context;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class ProductRepositoryDal : EFEntityRepositoryBase<Product, AppDbContext>, IProductDal
    {
        public ProductRepositoryDal(AppDbContext context) : base(context) {}
    }
}

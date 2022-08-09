using Business.Services;
using DAL.Abstracts;
using DAL.Context;
using Entity.Entities;
using Exceptions.EntityExceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Repository
{
    public class ProductRepository : IProductService
    {
        private readonly IProductDal _productDal;
        public ProductRepository(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public async Task<List<Product>> GetAll()
        {
            var data = await _productDal.GetAllAsync(p => !p.IsDeleted, includes: "ProductImages.Image");

            if (data is null)
            {
                throw new EntityCouldNotBeFoundException();
            }

            return data;
        }

        public async Task<Product> Get(int? id)
        {
            var data = await _productDal.GetAsync(p => p.Id == id && !p.IsDeleted, includes:  "ProductImages.Image");

            if (data is null)
            {
                throw new EntityCouldNotBeFoundException();
            }

            return data;
        }

        public Task Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, Product entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int? id)
        {
            throw new NotImplementedException();
        }
    }
}

using System.Collections.Generic;
using Week3.Domain.Entities;

namespace Week3.Services.Abstract
{
    public interface IProductService
    {
        public List<Product> GetAll();
        public void Add(Product entity);
        Product GetById(int id);
    }
}

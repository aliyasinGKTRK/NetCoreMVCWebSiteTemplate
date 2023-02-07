using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetByDetail(int id);
        void Add(Product product);
        void Delete(Product product);
        void Update(Product product);
        Product GetById(int id);
        List<Product> GetAll();
        List<Product> GetByCategory(int categoryId);
    }
}

using Ecommerce.Interface;
using Ecommerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Repository
{
    public class ProductRepo : IProduct
    {
        public Task<int> Create(ProductM t)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductM>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ProductM> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(ProductM t)
        {
            throw new NotImplementedException();
        }
    }
}

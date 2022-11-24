using Ecommerce.Interface;
using Ecommerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Repository
{
    public class CategoryRepo : ICategory
    {
        public Task<int> Create(CategoryM t)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CategoryM>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<CategoryM> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(CategoryM t)
        {
            throw new NotImplementedException();
        }
    }
}

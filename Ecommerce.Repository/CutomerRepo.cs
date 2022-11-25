using Ecommerce.Interface;
using Ecommerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Repository
{
    public class CutomerRepo : ICustomer
    {
        public Task<int> Create(CustomerM t)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CustomerM>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<CustomerM> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(CustomerM t)
        {
            throw new NotImplementedException();
        }
    }
}

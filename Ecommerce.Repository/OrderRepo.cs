using Ecommerce.Interface;
using Ecommerce.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Repository
{
    public class OrderRepo : IOrder
    {
        public Task<int> Create(OrderM t)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<OrderM>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<OrderM> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(OrderM t)
        {
            throw new NotImplementedException();
        }
    }
}

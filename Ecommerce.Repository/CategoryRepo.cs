using Ecommerce.Data;
using Ecommerce.Interface;
using Ecommerce.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Repository
{
    public class CategoryRepo : ICategory
    {
        private readonly EcommerceDbContext db;
        public CategoryRepo(EcommerceDbContext _db)
        {
            this.db = _db;
        }
        public async Task<int> Create(CategoryM t)
        {
            db.Categories.Add(t);
            return await db.SaveChangesAsync();
        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CategoryM>> GetAll()
        {
            return await db.Categories.Where(i => i.IsDeleted == false).ToListAsync();
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

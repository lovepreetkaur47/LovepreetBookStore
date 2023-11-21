using LovepreetBook.DataAccess.Repository.ICoverTypeRepository;
using LovepreetBookStore.DataAccess.Data;
using LovepreetBook.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using LovepreetBook.DataAccess.Repository.IRepository;

namespace LovepreetBook.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _db = dbContext;
        }

        public void Update(Category category)
        {
            //us .NET LINQ to retrieve the first or default category object,
            //thn pass the id as a generic entity which matches the category ID
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if (objFromDb != null) //save changes if not null 
            {
                objFromDb.Name = category.Name;
                _db.SaveChanges();
            }

            throw new NotImplementedException();
        }
    }
}
using LovepreetBooks.DataAccess.Repository;
using LovepreetBook.DataAccess.Repository.IRepository;
using LovepreetBook.Model;
using LovepreetBookStore.DataAccess.Data;
using System;

namespace LovepreetBook.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepositary
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
       
    }
}

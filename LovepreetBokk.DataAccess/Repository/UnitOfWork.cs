using LovepreetBokk.DataAccess.Repository;
using LovepreetBook.DataAccess.Repository;
using LovepreetBook.DataAccess.Repository.ICoverTypeRepository;
using LovepreetBook.DataAccess.Repository.IRepository;
using LovepreetBook.Model;
using LovepreetBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LovepreetBook.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db; //the using statement

        public UnitOfWork(ApplicationDbContext db)   //constructor to use DI and inject in to the repositories
        {
            _db = db;
            Category = new CategoryRepository(_db);
            SP_Call = new SP_Call(_db);
            CoverType = new CoverTypeRepository(_db);
            Product = new ProductRepository(_db);

        }

        public ICategoryRepository Category { get; private set; }
        public ISP_Call SP_Call { get; private set; }

        public CoverTypeRepository CoverType { get; private set; }
        public ProductRepository Product { get; private set; }



        IRepository.ICoverTypeRepository IUnitOfWork.CoverType => throw new NotImplementedException();

        IProductRepository IUnitOfWork.Product => throw new NotImplementedException();

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()  //all changes will be saved when the save method is called at the 'parent' level
        {
            _db.SaveChanges();
        }
    }
}
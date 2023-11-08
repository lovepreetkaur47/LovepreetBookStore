﻿using LovepreetBook.DataAccess.Repository.IRepository;
using LovepreetBookStore.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace LovepreetBook.DataAccess.Repository
{
    public class UnitOfWork //mke method public to acces the class
    {
        private readonly ApplicationDbContext _db; //the using statement
        public UnitOfWork(ApplicationDbContext db) //constructor to use DI and inject in to the repositories
        {
            _db = db;
            Category = new CategoryRepository(_db);
            SP_Call = new SP_Call(_db);
            
        }
        public ICategoryRepository Category { get; private set; }
        public ISP_Call SP_Call { get; private set; }

       
        public void Dispose()
        {
            _db.Dispose();
        }
         public void Save() //all changes save method is called at the parent level
         {

            _db.SaveChanges();
         }
    }
}

      


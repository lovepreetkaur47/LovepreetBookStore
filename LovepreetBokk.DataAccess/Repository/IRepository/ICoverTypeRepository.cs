using LovepreetBook.DataAccess.Repository.ICoverTypeRepository;
using LovepreetBook.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LovepreetBook.DataAccess.Repository.IRepository
{
    public interface ICoverTypeRepository : IRepository<CoverType>
    {
        void Update(CoverType coverType);
    }
}
﻿using LovepreetBook.DataAccess.Repository.ICoverTypeRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace LovepreetBook.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }

        ISP_Call SP_Call { get; }

        ICoverTypeRepository CoverType { get; }

        void Save();
    }
}
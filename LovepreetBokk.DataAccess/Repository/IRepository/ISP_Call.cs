using Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace LovepreetBook.DataAccess.Repository.ICoverTypeRepository
{
    public interface ISP_Call : IDisposable
    {
        //e. g. first coloum of first row 
        T Single<T>(string procedurename, DynamicParameters param = null);
        //execute something to be database but not recetrivee
        void Execute(string procedurename, DynamicParameters param = null);
        //retrive the complete row or record
        T OneRecord<T>(string procedurename, DynamicParameters param = null);
        //get all rows
        IEnumerable<T> List<T>(string procedurename, DynamicParameters param = null);
        //strored procedure that returns two tables
        Tuple<IEnumerable<T1>, IEnumerable<T2>> List<T1, T2>(string procedurename, DynamicParameters param = null);
    }
}

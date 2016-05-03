using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubebarnRepository.GenericRepository
{
    public interface IGenericFunctions<T> where T : class
    {
        T GetById(string Id);
        T GetById(int Id);
        IList<T> FindMany(Func<T, bool> predicate);
        T FindOne(Func<T, bool> predicate);
        void SaveChanges(out CubebarnRepository.Enums.EnumiratedData.Status status);
        void Add(T entity);
        IList<T> Pagination(int pageIndex, int pageSize);
        void DisposeConnection();
        IList<T> GetAll();
    }
}

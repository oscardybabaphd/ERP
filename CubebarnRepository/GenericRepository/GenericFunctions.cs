using AppContext;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubebarnRepository.GenericRepository
{
    public class GenericFunctions<T>:IGenericFunctions<T> where T : class
    {
        protected AppContextClass session = null;
        protected DbSet<T> dbObject { get; set; }
        public GenericFunctions()
        {
            var session = AppContextClass.Create();
            dbObject = session.Set<T>();
        }
        public T GetById(string Id)
        {
            return dbObject.Find(Id);
        }
        public T GetById(int Id)
        {
             return dbObject.Find(Id);
        }
        public IList<T> FindMany(Func<T, bool> predicate)
        {
            var _result = dbObject.Where(predicate).ToList<T>();
            return _result;
        }
        public IList<T> GetAll()
        {
            var _result = dbObject.ToList() as List<T>;
            return _result;
        }
        public IList<T> Pagination(int pageIndex, int pageSize)
        {
            var _result = GetAll().Skip(pageIndex * pageSize).Take(pageSize).ToList();
            return _result;
        }
        public T FindOne(Func<T, bool> predicate)
        {
            var _result = dbObject.FirstOrDefault<T>(predicate);
            return _result;
        }
        public void SaveChanges(out CubebarnRepository.Enums.EnumiratedData.Status status)
        {
            status = Enums.EnumiratedData.Status.None;
            using (var trxn = session.Database.BeginTransaction())
            {
                try
                {
                    var _result = session.SaveChanges();
                    trxn.Commit();
                    if(_result == -1)
                    {
                        status = Enums.EnumiratedData.Status.Successful;
                    }
                }
                catch (Exception)
                {
                    trxn.Rollback();
                    status = Enums.EnumiratedData.Status.Failed;
                    throw;
                }
            } 
        }
        public void Add(T entity)
        {
            dbObject.Add(entity);
        }

        public void Update(T entity)
        {
            dbObject.Attach(entity);
            session.Entry(entity).State = EntityState.Modified;
            CubebarnRepository.Enums.EnumiratedData.Status status = Enums.EnumiratedData.Status.None;
            SaveChanges(out status);
        }

        public void Delete(T entity)
        {
            dbObject.Attach(entity);
            session.Entry(entity).State = EntityState.Deleted;
            CubebarnRepository.Enums.EnumiratedData.Status status = Enums.EnumiratedData.Status.None;
            SaveChanges(out status);
        }
        public void DisposeConnection()
        {
            session.Dispose();
        }
    }
}

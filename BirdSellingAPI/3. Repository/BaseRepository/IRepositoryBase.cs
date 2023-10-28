using BirdSellingAPI._3._Repository.Data;
using System.Linq.Expressions;

namespace BirdSellingAPI._3._Repository.BaseRepository
{
    public interface IRepositoryBase<T> where T : class
    {
        public List<T> GetAll();
        public T GetById (string id);
        public void Create (T entity);
        public void Update (T entity);
        public void Delete (T entity);
        public T GetSingle(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
        public IQueryable<T> Get(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includeProperties);
        // void Create(BirdCategoryEntity orderEntity);
    }
}

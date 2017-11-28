using Microsoft.EntityFrameworkCore;

namespace HTActive.Core.Repository
{
    public class BaseUnitOfWork<K> : IBaseUnitOfWork<K> where K : DbContext
    {
        public BaseUnitOfWork(K dataContext)
        {
            this.DbContext = dataContext;
        }

        public K DbContext { get; private set; }

        public void Commit()
        {
            this.DbContext.ChangeTracker.DetectChanges();
            this.DbContext.SaveChanges();
        }
    }
    public interface IBaseUnitOfWork<K> where K : DbContext
    {
        K DbContext { get; }
        void Commit();
    }
}

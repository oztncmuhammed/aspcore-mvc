using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;

namespace Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T>
    where T : class, new()
    {
        protected readonly RepositoryContext _contex;
        protected RepositoryBase(RepositoryContext contex)
        {
            _contex = contex;
        }

        public IQueryable<T> FindAll(bool trackChanges)
        {
            return trackChanges
                ?_contex.Set<T>()
                :_contex.Set<T>().AsNoTracking();
        }
    }
}
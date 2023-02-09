using EfUow.Models;
using EfUow.Repositories.Contexts;
using Microsoft.EntityFrameworkCore;

namespace EfUow.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly LibraryDbContext _libraryDb;
        private readonly DbSet<TEntity> _dbSet;

        public Repository(LibraryDbContext libraryDb)
        {
            ArgumentNullException.ThrowIfNull(libraryDb, nameof(libraryDb));

            _libraryDb = libraryDb;
            _dbSet = libraryDb.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public TEntity? GetById(int Id)
        {
            return _dbSet.Find(Id);
        }

        public IEnumerable<TEntity>? GetList(Func<TEntity, bool>? predicate = null)
        {
            return predicate is null ? _dbSet.ToList() : _dbSet.Where(predicate).ToList();
        }

        public void Remove(TEntity entity)
        {
            _dbSet.Remove(entity);
        }

        public void Update(TEntity entity)
        {
            _dbSet.Update(entity);
        }
    }
}

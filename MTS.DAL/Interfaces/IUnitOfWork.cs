using System;

namespace MTS.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;

        bool GetExecuteSqlCommand(string str);
    }
}

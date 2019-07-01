using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alunos.Core.Interface.Repository
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        void AddRange(List<TEntity> lstObj);
        TEntity GetById(int id);
        IQueryable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(TEntity obj);
        void Dispose();
    }
}

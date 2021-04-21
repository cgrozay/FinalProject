using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DateAccess.Abstract
{
    //generic constraint.(generik kısıtlama)
    //class : referenas tip
    //IEntity: IEntity olabilir ve ya IEntity implemente eden bir nesne olabilir.
    //new(): new lenebilir olmalıdır.
    public interface IEntityRepository<T>where T:class,IEntity, new() //generiği kısıtlama şartı. class IEntity olabilir sadece.
    {
        
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        
    }
}

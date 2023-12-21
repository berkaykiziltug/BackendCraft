using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;


namespace Core.DataAccess
{
    //generic constraint
    //class : referans tip olabilir. Class demek degil.
    //new() : new'lenebilir olmalı (yani IEntity newlenemez). IEntity direkt yazılmasın diye. Yani soyut bir nesne veremeyelim IEntity olan.
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        //linq ile geliyor expression. Parametre verebilmek için hangi verinin gelecegini.
        List<T> GetAll(Expression<Func<T,bool>> filter = null);
        T Get(Expression<Func<T,bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}

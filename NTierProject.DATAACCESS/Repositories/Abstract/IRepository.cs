﻿using NTierProject.CORE.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace NTierProject.DATAACCESS.Repositories.Abstract
{
    public interface IRepository<T> where T : CoreEntity
    {
        bool Add(T item);
        bool Add(List<T> items);
        bool Update(T item);
        bool Remove(T item);
        bool Remove(Guid id);
        bool RemoveAll(Expression<Func<T, bool>> exp);//Linq expression yazım yöntemi
        T GetByID(Guid id);
        T GetByDefault(Expression<Func<T, bool>> exp);
        List<T> GetActive();
        List<T> GetDefault(Expression<Func<T, bool>> exp);
        List<T> GetAll();
        bool Activate(Guid id);
        bool Any(Expression<Func<T, bool>> exp);
        int Save();
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

using System.Data.Entity.Infrastructure;

namespace SuperheroesUniverse.Data.Repository
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> All { get; }

        DbContextConfiguration Configuration { get; }

        T GetById(object id);

        IEnumerable<T> GetAll();

        IEnumerable<T> GetAll(Expression<Func<T, bool>> filterExpression);

        IEnumerable<T> GetAll<T1>(Expression<Func<T, bool>> filterExpression, Expression<Func<T, T1>> sortExpression);

        IEnumerable<T2> GetAll<T1, T2>(Expression<Func<T, bool>> filterExpression, Expression<Func<T, T1>> sortExpression, Expression<Func<T, T2>> selectExpression);

        void Add(T entity);

        void AddRange(IEnumerable<T> entities);

        void Update(T entity);

        void Delete(T entity);
    }
}
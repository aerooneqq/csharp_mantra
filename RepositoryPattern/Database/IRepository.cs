﻿using System;
using System.Collections.Generic;

using RepositoryPattern.Filters.Base;

namespace RepositoryPattern.Database
{
    /// <summary>
    /// This is the main interface which provides the access to the databases' functions.
    /// </summary>
    interface IRepository<T> : IDisposable where T : UniqueEntity
    {
        List<T> Get(IFilter filter);
        void Insert(T entity);
        void Delete(IFilter filter);
        void Update(T entity);

        void Print();
    }
}

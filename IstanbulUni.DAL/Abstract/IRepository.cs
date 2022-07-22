﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IstanbulUni.DAL.Abstract
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        void Insert(T d);
        void Delete(T d);
        void Update(T d);
       T get(Expression<Func<T, bool>> filter);
    }
}

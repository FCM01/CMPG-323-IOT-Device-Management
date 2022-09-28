using System;
using System.Collections.Generic;
using System.Linq.Expressions;

public interface IGenericRepository<T> where T : class
{
    T GetById(Guid? id);
    IEnumerable<T> GetAll();
    void Add(T entity);
    void Update(T entity);
    //this Getlist method is primarly used by the device controller 
    IEnumerable<l> Getlist<l>() where l : class;
    void Delete(T entity);
}


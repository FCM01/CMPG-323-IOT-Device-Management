using DeviceManagement_WebApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    protected readonly ConnectedOfficeContext _context;
    public GenericRepository(ConnectedOfficeContext context)
    {
        _context = context;
    }
    public void Add(T entity)
    {
        _context.Set<T>().Add(entity);
    }
    public void AddRange(IEnumerable<T> entities)
    {
        _context.Set<T>().AddRange(entities);
    }

    //public void AddRange(IEnumerable<T> entities)
    //{
    //    throw new NotImplementedException();
    //}

    public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
    {
        return _context.Set<T>().Where(expression);
    }

    //public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
    //{
    //    throw new NotImplementedException();
    //}

    public IEnumerable<T> GetAll()
    {
        return _context.Set<T>().ToList();
    }
    public T GetById(Guid? id)
    {
        return _context.Set<T>().Find(id);
    }
    public void Remove(T entity)
    {
        _context.Set<T>().Remove(entity);
    }
    public void RemoveByID(Guid id)
    {
         _context.Set<T>().Remove(_context.Set<T>().Find(id));
    }

    public T RemoveByID(Guid? id)
    {
        throw new NotImplementedException();
    }

    public void RemoveRange(IEnumerable<T> entities)
    {
        _context.Set<T>().RemoveRange(entities);
    }

    //public void RemoveRange(IEnumerable<T> entities)
    //{
    //    throw new NotImplementedException();
    //}

    //IEnumerable<T> IGenericRepository<T>.GetAll()
    //{
    //    throw new NotImplementedException();
    //}
}



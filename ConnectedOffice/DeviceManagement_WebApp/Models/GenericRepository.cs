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
        _context.SaveChanges();
    }

    public void Update(T entity)
    {
        _context.Set<T>().Update(entity);
        _context.SaveChangesAsync();
    }

    public IEnumerable<l> Getlist<l>() where l : class
    {
        return _context.Set<l>().ToList();
    }
    public IEnumerable<T> GetAll()
    {
        return _context.Set<T>().ToList();
    }
    public T GetById(Guid? id)
    {
        return _context.Set<T>().Find(id);
    }
    public void Delete(T entity)
    {
        
        _context.Set<T>().Remove(entity);
        _context.SaveChangesAsync();
    }

    public bool Exists(Guid? id )
    {
        
        if (_context.Set<T>().Find(id) != null)
        {
            return true;
        }
        return false;
    }

  
}



using System;
using System.Collections.Generic;
using System.Linq.Expressions;

public interface IGenericRepository<T> where T : class
{
    T GetById(Guid? id);
    //exists method
    bool Exists(Guid? id);
    IEnumerable<T> GetAll();
    //create method 
    void Add(T entity);
    //update method 
    void Update(T entity);
    //this Getlist method is primarly used by the device controller  i beleieve it should return the array require for Category and Zones
    IEnumerable<l> Getlist<l>() where l : class;
    //delete method
    void Delete(T entity);
}


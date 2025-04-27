using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using EntityLayer.Concrete; // T'nin bulunduğu katman
using DataAccessLayer.Concrete;
using DataAccessLayer.Abstract;
using System.Runtime.InteropServices.WindowsRuntime;
using DataAccessLayer; // Context sınıfın burada

public class GenericRepository<T> : IRepository<T> where T : class
{
    Context c = new Context();
    DbSet<T> _object;

    public GenericRepository()
    {
        _object = c.Set<T>();
    }

    public void Insert(T p)
    {
        var AddeEntity = c.Entry(p);
        AddeEntity.State = EntityState.Added;
       // _object.Add(p);
        c.SaveChanges();
    }

    public void Delete(T p)
    {
        var deletedEntity= c.Entry(p);
        deletedEntity.State = EntityState.Deleted;  
        //_object.Remove(p);
        c.SaveChanges();
    }

    public void Update(T p)
    {
        var UpdatedEntity = c.Entry<T>(p);
        UpdatedEntity.State = EntityState.Modified; 
        c.SaveChanges();

    } 

    public List<T> List()
    {
        return _object.ToList();
    }

    public List<T> List(Expression<Func<T, bool>> filter)
    {
        return _object.Where(filter).ToList();
    }

    public T Get(Expression<Func<T, bool>> filter)
    {
        return _object.SingleOrDefault(filter);
    }
}

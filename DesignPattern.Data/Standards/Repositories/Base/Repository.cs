using Dapper.Contrib.Extensions;
using DesignPattern.Data.Interfaces;
using DesignPattern.Data.Interfaces.Repositories;
using DesignPattern.Domain.Standards.Tools;
using System;
using System.Collections.Generic;

namespace DesignPattern.Data.Standards.Repositories
{
  public class Repository<Entity> : Disposer, IRepository<Entity>
    where Entity : class
  {
    private readonly IDbContext db;

    public Repository(IDbContext db)
      : base(IntPtr.Zero)
    {
      this.db = db;
    }

    public long Create(Entity entity)
    {
      return db.Connection.Insert(entity);
    }

    public long Create(IEnumerable<Entity> entities)
    {
      return db.Connection.Insert(entities);
    }

    public Entity Read(int entityId)
    {
      return db.Connection.Get<Entity>(entityId);
    }

    public IEnumerable<Entity> ReadAll()
    {
      return db.Connection.GetAll<Entity>();
    }

    public bool Update(Entity entity)
    {
      return db.Connection.Update(entity);
    }

    public bool Update(IEnumerable<Entity> entities)
    {
      return db.Connection.Update(entities);
    }

    public bool Delete(int entityId)
    {
      Entity entity;

      entity = Read(entityId);

      return Delete(entity);
    }

    public bool Delete(Entity entity)
    {
      return db.Connection.Delete(entity);
    }

    public bool Delete(IEnumerable<Entity> entities)
    {
      return db.Connection.Delete(entities);
    }
  }
}

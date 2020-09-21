using DesignPattern.Core.Interfaces.Services.Base;
using DesignPattern.Data.Standards.Repositories;
using DesignPattern.Domain.Standards.Tools;
using System;
using System.Collections.Generic;

namespace DesignPattern.Core.Standards.Services.Base
{
  public class Service<Entity> : Disposer, IService<Entity>
    where Entity : class
  {
    private readonly Repository<Entity> repository;
    
    public Service(Repository<Entity> repository)
      : base(IntPtr.Zero)
    {
      this.repository = repository;
    }

    public long Create(Entity entity)
    {
      return repository.Create(entity);
    }

    public long Create(IEnumerable<Entity> entities)
    {
      return repository.Create(entities);
    }

    public bool Delete(int entityId)
    {
      return repository.Delete(entityId);
    }

    public bool Delete(Entity entity)
    {
      return repository.Delete(entity);
    }

    public bool Delete(IEnumerable<Entity> entities)
    {
      return repository.Delete(entities);
    }

    public Entity Read(int entityId)
    {
      return repository.Read(entityId);
    }

    public IEnumerable<Entity> ReadAll()
    {
      return repository.ReadAll();
    }

    public bool Update(Entity entity)
    {
      return repository.Update(entity);
    }

    public bool Update(IEnumerable<Entity> entities)
    {
      return repository.Update(entities);
    }
  }
}

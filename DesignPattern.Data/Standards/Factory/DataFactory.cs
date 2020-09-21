using DesignPattern.Data.Interfaces;
using DesignPattern.Data.Interfaces.Context;
using DesignPattern.Data.Interfaces.Factory;
using DesignPattern.Data.Interfaces.Repositories;
using DesignPattern.Data.Standards.Context;
using DesignPattern.Data.Standards.Repositories;
using DesignPattern.Domain.Standards.Tools;
using Microsoft.Data.Sqlite;
using System;

namespace DesignPattern.Data.Standards.Factory
{
  public class DataFactory : Disposer, IDataFactory
  {
    public DataFactory()
      : base(IntPtr.Zero) 
    {
    }

    #region Database connection
    public SqliteConnection CreateDbConnection(string connectionString)
    {
      return new SqliteConnection(connectionString);
    }

    public IDbContext CreateDbContext()
    {
      return new DbContext(this);
    }

    public ISeed CreateSeed()
    {
      IDbContext db = CreateDbContext();
      return new Seed(db);
    }
    #endregion

    #region Repositories
    public IOrderRepository CreateOrderRepository()
    {
      IDbContext db = CreateDbContext();
      return new OrderRepository(db);
    }

    public IUserRepository CreateUserRepository()
    {
      IDbContext db = CreateDbContext();
      return new UserRepository(db);
    }
    #endregion
  }
}

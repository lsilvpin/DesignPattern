using DesignPattern.Data.Interfaces;
using DesignPattern.Data.Interfaces.Factory;
using DesignPattern.Domain.Standards.Constants;
using DesignPattern.Domain.Standards.Tools;
using Microsoft.Data.Sqlite;
using System;

namespace DesignPattern.Data.Standards.Context
{
  public class DbContext : Disposer, IDbContext
  {
    public string FullName { get; set; }
    public SqliteConnection Connection { get; set; }

    public DbContext(IDataFactory dataFactory)
      : base(IntPtr.Zero)
    {
      FullName = DbConfig.GetDbFullName();
      string connectionString = DbConfig.GetDbConnectionString();
      Connection = dataFactory.CreateDbConnection(connectionString);
    }
  }
}

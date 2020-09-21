using Microsoft.Data.Sqlite;
using System;

namespace DesignPattern.Data.Interfaces
{
  public interface IDbContext : IDisposable
  {
    string FullName { get; set; }
    SqliteConnection Connection { get; set; }
  }
}

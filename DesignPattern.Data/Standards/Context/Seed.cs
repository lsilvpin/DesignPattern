using Dapper;
using DesignPattern.Data.Interfaces;
using DesignPattern.Data.Interfaces.Context;
using DesignPattern.Domain.Standards.Tools;
using Microsoft.Data.Sqlite;
using System;
using System.Data.SQLite;
using System.IO;

namespace DesignPattern.Data.Standards.Context
{
  public class Seed : Disposer, ISeed
  {
    private readonly IDbContext db;

    public Seed(IDbContext db)
      : base(IntPtr.Zero)
    {
      this.db = db;
    }

    public void CreateDbIfNecessary()
    {
      if (!File.Exists(db.FullName))
      {
        SQLiteConnection.CreateFile(db.FullName);

        using (SqliteConnection connection = db.Connection)
        {
          connection.Open();

          connection.Execute(@"CREATE TABLE Users (
                                 Id INTEGER NOT NULL,
                                 Name varchar(255) UNIQUE NOT NULL,
                                 Password varchar(50) NOT NULL,
                                 CreationTime DATETIME NOT NULL,
                                 PRIMARY KEY (Id AUTOINCREMENT)
                               );

                               CREATE TABLE Orders (
                                  Id INTEGER NOT NULL,
                                  Description varchar(50) NOT NULL,
                                  Product varchar(50) NOT NULL,
                                  Amount INTEGER NOT NULL,
                                  CreationTime DATETIME NOT NULL,
                                  UserId INTEGER NOT NULL,
                                  PRIMARY KEY (Id AUTOINCREMENT),
                                  FOREIGN KEY (UserId) REFERENCES Users(UserId)
                               );"
          );

          connection.Close();
        }
      }
    }
  }
}

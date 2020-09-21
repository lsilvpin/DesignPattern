using DesignPattern.Data.Interfaces.Context;
using DesignPattern.Data.Interfaces.Repositories;
using Microsoft.Data.Sqlite;
using System;

namespace DesignPattern.Data.Interfaces.Factory
{
  /// <summary>
  /// Fábrica e supervisor de objetos da camada Data
  /// </summary>
  public interface IDataFactory : IDisposable
  {
    #region Database connection
    /// <summary>
    /// Cria um DbContext para acessar banco de dados
    /// </summary>
    /// <returns>DbContext</returns>
    IDbContext CreateDbContext();

    /// <summary>
    /// Cria uma conexão com o banco de dados
    /// </summary>
    /// <param name="connectionString">String de conexão</param>
    /// <returns>Conexão</returns>
    SqliteConnection CreateDbConnection(string connectionString);

    /// <summary>
    /// Cria um objeto de preparação do banco de dados
    /// </summary>
    /// <returns>Seed</returns>
    ISeed CreateSeed();
    #endregion

    #region Repositories
    /// <summary>
    /// Cria objeto de acesso à tabela de usuários do banco de dados
    /// </summary>
    /// <returns>UserRepository</returns>
    IUserRepository CreateUserRepository();

    /// <summary>
    /// Cria objeto de acesso à tabela de pedidos do banco de dados
    /// </summary>
    /// <returns>OrderRepository</returns>
    IOrderRepository CreateOrderRepository();
    #endregion
  }
}

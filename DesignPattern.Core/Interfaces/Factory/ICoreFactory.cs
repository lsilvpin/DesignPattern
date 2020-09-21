using DesignPattern.Core.Interfaces.Services;
using DesignPattern.Data.Interfaces.Factory;
using DesignPattern.Domain.Interfaces.Factory;
using System;

namespace DesignPattern.Core.Interfaces.Factory
{
  /// <summary>
  /// Fábrica e supervisora de instâncias de objetos na camada Core
  /// </summary>
  public interface ICoreFactory : IDisposable
  {
    #region Factories
    /// <summary>
    /// Intancia um objeto DataFactory
    /// </summary>
    /// <returns>Uma instância de DataFactory</returns>
    IDataFactory CreateDataFactory();

    /// <summary>
    /// Cria uma instância de DomainFactory
    /// </summary>
    /// <returns>Intância de DomainFactory</returns>
    IDomainFactory CreateDomainFactory();
    #endregion

    #region Services
    /// <summary>
    /// Instancia um objeto UserService
    /// </summary>
    /// <returns>Uma instância de UserService</returns>
    IUserService CreateUserService();

    /// <summary>
    /// Instacia um objeto OrderService
    /// </summary>
    /// <returns>Uma instância de OrderService</returns>
    IOrderService CreateOrderService();
    #endregion
  }
}

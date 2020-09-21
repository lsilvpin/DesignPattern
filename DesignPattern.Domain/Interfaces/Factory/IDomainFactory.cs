using DesignPattern.Domain.Interfaces.Tools;
using System;

namespace DesignPattern.Domain.Interfaces.Factory
{
  /// <summary>
  /// Fábrica e supervisora de instâncias de objetos da camada Domain
  /// </summary>
  public interface IDomainFactory : IDisposable
  {
    /// <summary>
    /// Cria uma instância de PathHandler
    /// </summary>
    /// <returns>Instância de PathHandler</returns>
    IPathHandler CreatePathHandler();
  }
}

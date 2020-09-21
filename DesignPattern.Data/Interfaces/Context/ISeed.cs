using System;

namespace DesignPattern.Data.Interfaces.Context
{
  /// <summary>
  /// Preparador do banco de dados
  /// </summary>
  public interface ISeed : IDisposable
  {
    /// <summary>
    /// Cria banco de dados caso ele ainda não exista
    /// </summary>
    void CreateDbIfNecessary();
  }
}

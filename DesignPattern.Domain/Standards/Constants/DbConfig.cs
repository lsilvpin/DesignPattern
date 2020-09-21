using DesignPattern.Domain.Interfaces.Factory;
using DesignPattern.Domain.Interfaces.Tools;

namespace DesignPattern.Domain.Standards.Constants
{
  /// <summary>
  /// Armazena e trata configurações do banco de dados
  /// </summary>
  public static class DbConfig
  {
    #region Configurations
    /// <summary>
    /// Nome do banco de dados
    /// </summary>
    private static readonly string Name = "DesignPatternDataBase";

    /// <summary>
    ///  Caminho virtual do banco de dados
    /// </summary>
    private static readonly string VirtualPath = @"~\DesignPattern";
    #endregion

    #region Tools
    /// <summary>
    /// Cria por meio da DomainFactory uma instância da ferramenta PathHandler
    /// </summary>
    private static IPathHandler PathHandler
    {
      get
      {
        IPathHandler PathHandler;
        using (IDomainFactory domainFactory = new DomainFactory())
        {
          PathHandler = domainFactory.CreatePathHandler();
        }

        return PathHandler;
      }
    }
    #endregion

    #region Interactor
    /// <summary>
    /// Retorna a connection string
    /// </summary>
    /// <returns>Connection string</returns>
    public static string GetDbConnectionString()
    {
      return string.Concat("Data Source=", GetDbFullName(), ";");
    }

    /// <summary>
    /// Retorna o caminho (nome) completo do banco de dados
    /// </summary>
    /// <returns>Nome completo do banco de dados</returns>
    public static string GetDbFullName()
    {
      string virtualName = string.Concat(VirtualPath, @"\", Name, ".db");
      string fullName = PathHandler.MapPath(virtualName);
      return fullName;
    }
    #endregion
  }
}

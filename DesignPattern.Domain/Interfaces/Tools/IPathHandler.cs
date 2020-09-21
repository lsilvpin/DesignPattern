namespace DesignPattern.Domain.Interfaces.Tools
{
  /// <summary>
  /// Manipulador de Paths
  /// </summary>
  public interface IPathHandler
  {
    /// <summary>
    /// Concatena diretório raiz da aplicação com caminho virtual
    /// </summary>
    /// <param name="virtualPath">Caminho virtual de um dado</param>
    /// <returns>Caminho físico do dado</returns>
    string MapPath(string virtualPath);
  }
}

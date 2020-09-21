using DesignPattern.Domain.Interfaces.Tools;
using System.IO;
using System.Reflection;

namespace DesignPattern.Domain.Standards.Tools
{
  public class PathHandler : IPathHandler
  {
    #region Public methods
    public string MapPath(string virtualPath)
    {
      while (virtualPath.StartsWith("~"))
        virtualPath = virtualPath.Substring(1);

      string root = GetApplicationRootDirectoryPhisicalPath();

      return string.Concat(root, virtualPath);
    }
    #endregion

    #region Private methods
    private static string GetApplicationRootDirectoryPhisicalPath()
    {
      string result;

      result = Assembly.GetExecutingAssembly().CodeBase;
      FileInfo file = new FileInfo(result);
      result = string.Concat("C:", @file.DirectoryName.Split("C:")[2]);

      for (int i = 0; i < 5; i++)
      {
        DirectoryInfo parentDirectory = Directory.GetParent(result);
        result = parentDirectory.FullName;
      }

      return result;
    }
    #endregion
  }
}

using DesignPattern.Core.Interfaces.Factory;
using DesignPattern.Core.Standards.Factory;
using DesignPattern.Data.Interfaces.Context;
using DesignPattern.Data.Interfaces.Factory;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace DesignPattern.Api
{
  public class Program
  {
    public static void Main(string[] args)
    {
      IHost webHost = CreateHostBuilder(args).Build();

      #region Before running application
      using (ICoreFactory coreFactory = new CoreFactory())
      {
        using IDataFactory dataFactory = coreFactory.CreateDataFactory();
        ISeed seed = dataFactory.CreateSeed();
        seed.CreateDbIfNecessary();
      }
      #endregion

      webHost.Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
              webBuilder.UseStartup<Startup>();
            });
  }
}

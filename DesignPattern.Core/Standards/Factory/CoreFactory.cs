using DesignPattern.Core.Interfaces.Factory;
using DesignPattern.Core.Interfaces.Services;
using DesignPattern.Core.Standards.Services;
using DesignPattern.Data.Interfaces.Factory;
using DesignPattern.Data.Interfaces.Repositories;
using DesignPattern.Data.Standards.Factory;
using DesignPattern.Data.Standards.Repositories;
using DesignPattern.Domain.Interfaces.Factory;
using DesignPattern.Domain.Standards;
using DesignPattern.Domain.Standards.Tools;
using System;

namespace DesignPattern.Core.Standards.Factory
{
  public class CoreFactory : Disposer, ICoreFactory
  {
    /// <summary>
    /// Só cria uma data factory quando é absolutamente necessário
    /// Por meio do using (dataFactory) o Disposer.Dispose() é chamado imediatamente após seu uso
    /// </summary>
    private IDataFactory DataFactory { get { return CreateDataFactory(); } }

    public CoreFactory()
      : base(IntPtr.Zero)
    {
    }

    #region Factories
    public IDataFactory CreateDataFactory()
    {
      return new DataFactory();
    }

    public IDomainFactory CreateDomainFactory()
    {
      return new DomainFactory();
    }
    #endregion

    #region Services
    public IOrderService CreateOrderService()
    {
      IOrderRepository orderRepository;

      using (DataFactory)
      {
        orderRepository = DataFactory.CreateOrderRepository();
      }

      return new OrderService((OrderRepository)orderRepository);
    }

    public IUserService CreateUserService()
    {
      IUserRepository userRepository;

      using (DataFactory)
      {
        userRepository = DataFactory.CreateUserRepository();
      }

      return new UserService((UserRepository)userRepository);
    }
    #endregion
  }
}

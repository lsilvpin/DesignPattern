using DesignPattern.Core.Interfaces.Services;
using DesignPattern.Core.Standards.Services.Base;
using DesignPattern.Data.Standards.Repositories;
using DesignPattern.Domain.Standards.Entities;

namespace DesignPattern.Core.Standards.Services
{
  public class OrderService : Service<Order>, IOrderService
  {
    public OrderService(OrderRepository orderRepository)
      : base(orderRepository)
    {
    }
  }
}

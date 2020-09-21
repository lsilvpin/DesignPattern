using DesignPattern.Data.Interfaces;
using DesignPattern.Data.Interfaces.Repositories;
using DesignPattern.Domain.Standards.Entities;

namespace DesignPattern.Data.Standards.Repositories
{
  public class OrderRepository : Repository<Order>, IOrderRepository
  {
    public OrderRepository(IDbContext db)
      : base(db)
    {
    }
  }
}

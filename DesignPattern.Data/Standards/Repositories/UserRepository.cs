using DesignPattern.Data.Interfaces;
using DesignPattern.Data.Interfaces.Repositories;
using DesignPattern.Domain.Standards.Entities;

namespace DesignPattern.Data.Standards.Repositories
{
  public class UserRepository : Repository<User>, IUserRepository
  {
    public UserRepository(IDbContext db)
      : base(db)
    {
    }
  }
}

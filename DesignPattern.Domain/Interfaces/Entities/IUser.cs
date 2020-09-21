using System;
using System.Collections.Generic;

namespace DesignPattern.Domain.Interfaces.Entities
{
  public interface IUser : IDisposable
  {
    int Id { get; set; }
    string Name { get; set; }
    string Email { get; set; }
    string Password { get; set; }
    DateTime CreationTime { get; set; }

    IEnumerable<IOrder> Orders { get; set; }
  }
}

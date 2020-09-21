using System;
using System.Collections.Generic;

namespace DesignPattern.Domain.Interfaces.Entities
{
  public interface IOrder : IDisposable
  {
    int Id { get; set; }
    string Description { get; set; }
    string Product { get; set; }
    int Amount { get; set; }
    DateTime Time { get; set; }

    int UserId { get; set; }

    IEnumerable<IUser> Users { get; set; }
  }
}

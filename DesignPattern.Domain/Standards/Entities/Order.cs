using DesignPattern.Domain.Interfaces.Entities;
using DesignPattern.Domain.Standards.Tools;
using System;
using System.Collections.Generic;

namespace DesignPattern.Domain.Standards.Entities
{
  public class Order : Disposer, IOrder
  {
    public int Id { get; set; }
    public string Description { get; set; }
    public string Product { get; set; }
    public int Amount { get; set; }
    public DateTime Time { get; set; }

    public int UserId { get; set; }

    public IEnumerable<IUser> Users { get; set; }

    public Order()
      : base(IntPtr.Zero)
    {
    }
  }
}

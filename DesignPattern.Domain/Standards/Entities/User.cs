using DesignPattern.Domain.Interfaces.Entities;
using DesignPattern.Domain.Standards.Tools;
using System;
using System.Collections.Generic;

namespace DesignPattern.Domain.Standards.Entities
{
  public class User : Disposer, IUser
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public DateTime CreationTime { get; set; }

    public IEnumerable<IOrder> Orders { get; set; }

    public User()
      : base(IntPtr.Zero)
    {
    }
  }
}

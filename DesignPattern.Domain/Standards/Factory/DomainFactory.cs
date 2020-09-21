using DesignPattern.Domain.Interfaces.Factory;
using DesignPattern.Domain.Interfaces.Tools;
using DesignPattern.Domain.Standards.Tools;
using System;

namespace DesignPattern.Domain.Standards
{
  public class DomainFactory : Disposer, IDomainFactory
  {
    public DomainFactory()
      : base(IntPtr.Zero)
    {
    }

    public IPathHandler CreatePathHandler()
    {
      return new PathHandler();
    }
  }
}

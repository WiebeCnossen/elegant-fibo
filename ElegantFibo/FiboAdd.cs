namespace ElegantFibo {
  using System.Numerics;

  public sealed class FiboAdd : IFibo {
    private readonly IFibo one;

    private readonly IFibo two;

    public FiboAdd(IFibo one, IFibo two) {
      this.one = one;
      this.two = two;
    }

    public BigInteger Value => this.one.Value + this.two.Value;
  }
}
namespace ElegantFibo {
  using System;
  using System.Numerics;

  public sealed class MemoFibo : IFibo {
    private readonly Lazy<BigInteger> value;

    public MemoFibo(IFibo fibo) {
      this.value = new Lazy<BigInteger>(() => fibo.Value);
    }

    public BigInteger Value => this.value.Value;
  }
}
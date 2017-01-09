namespace HelloFib {
  using System;
  using System.Numerics;

  public class MemoFibo : IFibo {
    private readonly Lazy<BigInteger> value;

    public MemoFibo(IFibo fibo) {
      this.value = new Lazy<BigInteger>(() => fibo.Value);
    }

    public BigInteger Value => this.value.Value;
  }
}
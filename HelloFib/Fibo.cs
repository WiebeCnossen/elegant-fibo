namespace HelloFib {
  using System;
  using System.Numerics;

  internal class Fibo {
    private readonly ushort num;

    public Fibo(int num) : this(ToUShort(num)) {
    }

    private static ushort ToUShort(int num) {
      if (num < ushort.MinValue || num > ushort.MaxValue) {
        throw new ArgumentException(
          $"Num must be between {ushort.MinValue} and {ushort.MaxValue} inclusive",
          nameof(num));
      }

      return (ushort)num;
    }

    public Fibo(ushort num) {
      this.num = num;
    }

    public BigInteger Value => this.num < 2 ? 1 : new Fibo(this.num - 1).Value + new Fibo(this.num - 2).Value;
  }
}
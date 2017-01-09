namespace HelloFib {
  using System;

  internal interface IFiboFactory {
    IFibo Fibo(ushort num);
  }

  internal static class FiboFactoryExtensions {
    public static IFibo Fibo(this IFiboFactory fiboFactory, int num) => fiboFactory.Fibo(ToUShort(num));

    private static ushort ToUShort(int num) {
      if (num < ushort.MinValue || num > ushort.MaxValue)
        throw new ArgumentException(
          $"Num must be between {ushort.MinValue} and {ushort.MaxValue} inclusive",
          nameof(num));

      return (ushort)num;
    }
  }
}
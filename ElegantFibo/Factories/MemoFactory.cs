namespace ElegantFibo.Factories {
  using System.Collections.Generic;

  public sealed class MemoFactory : IFiboFactory {
    private readonly IDictionary<ushort, IFibo> cache;

    private readonly IFiboFactory fiboFactory;

    public MemoFactory(IDictionary<ushort, IFibo> cache, IFiboFactory fiboFactory) {
      this.cache = cache;
      this.fiboFactory = fiboFactory;
    }

    public IFibo Fibo(ushort num) {
      IFibo fibo;
      return this.cache.TryGetValue(num, out fibo) ? fibo : this.cache[num] = new MemoFibo(this.fiboFactory.Fibo(num));
    }
  }
}
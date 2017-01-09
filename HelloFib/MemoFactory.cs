namespace HelloFib {
  using System.Collections.Concurrent;
  using System.Collections.Generic;

  public class MemoFactory : IFiboFactory {
    private readonly IDictionary<ushort, IFibo> cache = new ConcurrentDictionary<ushort, IFibo>();

    private readonly IFiboFactory fiboFactory;

    public MemoFactory(IFiboFactory fiboFactory) {
      this.fiboFactory = fiboFactory;
    }

    public IFibo Fibo(ushort num) {
      IFibo fibo;
      return this.cache.TryGetValue(num, out fibo) ? fibo : this.cache[num] = this.fiboFactory.Fibo(num);
    }
  }
}
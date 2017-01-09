namespace HelloFib {
  using System.Collections.Concurrent;
  using System.Collections.Generic;

  public class MemoFactory : FiboFactory {
    private readonly IDictionary<ushort, IFibo> cache = new ConcurrentDictionary<ushort, IFibo>();

    public override IFibo Fibo(ushort num) {
      IFibo fibo;
      return this.cache.TryGetValue(num, out fibo) ? fibo : this.cache[num] = base.Fibo(num);
    }
  }
}
namespace ElegantFibo.Factories {
  using System.Collections.Concurrent;

  public sealed class MegaFactory : IFiboFactory {
    private readonly IFiboFactory fiboFactory;

    public MegaFactory() {
      var memo = new MetaMemoFactory(new ConcurrentDictionary<ushort, IFibo>());
      var fibo = new MetaFiboFactory { InnerFiboFactory = memo };
      memo.InnerFiboFactory = fibo;
      this.fiboFactory = memo;
    }

    public IFibo Fibo(ushort num) => this.fiboFactory.Fibo(num);
  }
}
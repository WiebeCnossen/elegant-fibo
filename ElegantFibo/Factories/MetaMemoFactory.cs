namespace ElegantFibo.Factories {
  using System.Collections.Generic;

  public sealed class MetaMemoFactory : MetaFactoryBase {
    private readonly IDictionary<ushort, IFibo> cache;

    public MetaMemoFactory(IDictionary<ushort, IFibo> cache) {
      this.cache = cache;
    }

    protected override IFiboFactory FiboFactory() => new MemoFactory(this.cache, this.InnerFiboFactory);
  }
}
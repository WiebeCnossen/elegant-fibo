namespace ElegantFibo.Factories {
  public sealed class MetaFiboFactory : MetaFactoryBase {
    protected override IFiboFactory FiboFactory() => new FiboFactory(this.InnerFiboFactory);
  }
}
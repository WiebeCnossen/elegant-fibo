namespace ElegantFibo.Factories {
  public abstract class MetaFactoryBase : IFiboFactory {
    public IFiboFactory InnerFiboFactory { get; set; }

    public IFibo Fibo(ushort num) => this.FiboFactory().Fibo(num);

    protected abstract IFiboFactory FiboFactory();
  }
}
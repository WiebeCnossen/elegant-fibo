namespace ElegantFibo.Factories {
  public sealed class FiboFactory : IFiboFactory {
    private readonly IFiboFactory fiboFactory;

    public FiboFactory(IFiboFactory fiboFactory) {
      this.fiboFactory = fiboFactory;
    }

    public IFibo Fibo(ushort num)
      =>
        num < 2
          ? (IFibo)new FiboOne()
          : new FiboAdd(this.fiboFactory.Fibo(new Num(num - 1).Value), this.fiboFactory.Fibo(new Num(num - 2).Value));
  }
}
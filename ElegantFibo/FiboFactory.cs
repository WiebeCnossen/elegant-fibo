namespace ElegantFibo {
  public class FiboFactory : IFiboFactory {
    public virtual IFibo Fibo(ushort num) => num < 2 ? (IFibo)new FiboOne() : new FiboAdd(this.Fibo(num - 1), this.Fibo(num - 2));
  }
}
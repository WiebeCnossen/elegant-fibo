namespace HelloFib {
  using System;

  public class FiboCommand : ICommand {
    private readonly IFibo fibo;

    private readonly string format;

    private readonly ushort num;

    public FiboCommand(string format, ushort num, IFibo fibo) {
      this.format = format;
      this.num = num;
      this.fibo = fibo;
    }

    public void Execute() => Console.WriteLine(this.format, this.num, this.fibo.Value);
  }
}
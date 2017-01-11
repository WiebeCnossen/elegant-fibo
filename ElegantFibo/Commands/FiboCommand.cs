namespace ElegantFibo.Commands {
  public sealed class FiboCommand : Command {
    private readonly IFibo fibo;

    private readonly string format;

    private readonly ushort num;

    public FiboCommand(string format, ushort num, IFibo fibo) {
      this.format = format;
      this.num = num;
      this.fibo = fibo;
    }

    public override void Execute() => this.Message = string.Format(this.format, this.num, this.fibo.Value);
  }
}
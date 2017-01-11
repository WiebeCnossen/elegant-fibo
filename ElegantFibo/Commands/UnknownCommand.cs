namespace ElegantFibo.Commands {
  public sealed class UnknownCommand : Command {
    public UnknownCommand(string text) {
      this.Message = text;
    }

    public override void Execute() {
    }
  }
}
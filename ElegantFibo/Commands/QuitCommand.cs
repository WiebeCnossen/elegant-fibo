namespace ElegantFibo.Commands {
  public sealed class QuitCommand : Command {
    public QuitCommand()
      : base(true) {
    }

    public override void Execute() {
    }
  }
}
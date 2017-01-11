namespace ElegantFibo.Commands {
  public sealed class Repl {
    private readonly ICommandFactory commandFactory;

    private readonly ITerminal terminal;

    public Repl(ITerminal terminal, ICommandFactory commandFactory) {
      this.terminal = terminal;
      this.commandFactory = commandFactory;
    }

    public void Run() {
      while (true) {
        var command = this.commandFactory.Command(this.terminal.Read());
        command.Execute();
        if (!string.IsNullOrEmpty(command.Message)) this.terminal.Write(command.Message);
        if (command.Quit) break;
      }
    }
  }
}
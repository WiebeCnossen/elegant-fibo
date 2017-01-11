namespace ElegantFibo.Commands {
  public abstract class Command : ICommand {
    protected Command(bool quit = false) {
      this.Quit = quit;
    }

    public string Message { get; protected set; }

    public bool Quit { get; }

    public abstract void Execute();
  }
}
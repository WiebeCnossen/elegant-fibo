namespace ElegantFibo.Commands {
  public interface ICommand {
    void Execute();

    string Message { get; }

    bool Quit { get; }
  }
}
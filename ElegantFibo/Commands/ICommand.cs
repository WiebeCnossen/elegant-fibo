namespace ElegantFibo.Commands {
  public interface ICommand {
    void Execute();

    bool Quit { get; }
  }
}
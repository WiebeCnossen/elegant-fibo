namespace ElegantFibo.Commands {
  public interface ICommandFactory {
    ICommand Command(string command);
  }
}
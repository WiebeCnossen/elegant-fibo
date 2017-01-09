namespace HelloFib {
  public interface ICommandFactory {
    ICommand Command(string command);
  }
}
namespace HelloFib {
  using System;

  public class QuitCommand : ICommand {
    public void Execute() => Environment.Exit(0);
  }
}
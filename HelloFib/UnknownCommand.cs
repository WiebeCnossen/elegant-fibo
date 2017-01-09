namespace HelloFib {
  using System;

  public class UnknownCommand : ICommand {
    private readonly string text;

    public UnknownCommand(string text) {
      this.text = text;
    }

    public void Execute() => Console.WriteLine(this.text);
  }
}
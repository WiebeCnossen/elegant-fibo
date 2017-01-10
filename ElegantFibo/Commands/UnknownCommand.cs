namespace ElegantFibo.Commands {
  using System;

  public class UnknownCommand : Command {
    private readonly string text;

    public UnknownCommand(string text) {
      this.text = text;
    }

    public override void Execute() => Console.WriteLine(this.text);
  }
}
namespace ElegantFibo.Commands {
  using System;

  public sealed class Repl {
    private readonly ICommandFactory commandFactory;

    private readonly string prompt;

    public Repl(string prompt, ICommandFactory commandFactory) {
      this.prompt = prompt;
      this.commandFactory = commandFactory;
    }

    public void Run() {
      while (true) {
        Console.Write($"{this.prompt} ");
        var command = this.commandFactory.Command(Console.ReadLine());
        command.Execute();
        if (command.Quit) break;
      }
    }
  }
}
namespace HelloFib {
  using System;

  public class Repl {
    private readonly string prompt;

    private readonly ICommandFactory commandFactory;

    public Repl(string prompt, ICommandFactory commandFactory) {
      this.prompt = prompt;
      this.commandFactory = commandFactory;
    }

    public void Run() {
      while (true) {
        Console.Write($"{this.prompt} ");
        this.commandFactory.Command(Console.ReadLine()).Execute();
      }
    }
  }
}
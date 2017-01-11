namespace ElegantFibo {
  using System;

  internal class ConsoleTerminal : ITerminal {
    private readonly string prompt;

    public ConsoleTerminal(string prompt) {
      this.prompt = $"{prompt} ";
    }

    public string Read() {
      Console.Write(this.prompt);
      return Console.ReadLine();
    }

    public void Write(string msg) => Console.WriteLine(msg);
  }
}
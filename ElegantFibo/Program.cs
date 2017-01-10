namespace ElegantFibo {
  using ElegantFibo.Commands;
  using ElegantFibo.Factories;

  internal class Program {
    private static void Main() => new Repl(">", new CommandFactory(new MegaFactory(), "Fibo[{0}] = {1}", "uh?")).Run();
  }
}
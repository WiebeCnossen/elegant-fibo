namespace HelloFib {
  internal class Program {
    private static void Main() => new Repl(">", new CommandFactory(new MemoFactory(), "Fibo[{0}] = {1}", "uh?")).Run();
  }
}
namespace ElegantFibo.Commands {
  using ElegantFibo.Factories;

  public sealed class CommandFactory : ICommandFactory {
    private readonly IFiboFactory fiboFactory;

    private readonly string fiboFormat;

    private readonly string unknownText;

    public CommandFactory(IFiboFactory fiboFactory, string fiboFormat, string unknownText) {
      this.fiboFactory = fiboFactory;
      this.fiboFormat = fiboFormat;
      this.unknownText = unknownText;
    }

    public ICommand Command(string command) {
      ushort num;
      return command == "quit"
               ? new QuitCommand()
               : (ushort.TryParse(command, out num)
                    ? (ICommand)new FiboCommand(this.fiboFormat, num, this.fiboFactory.Fibo(num))
                    : new UnknownCommand(this.unknownText));
    }
  }
}
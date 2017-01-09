namespace HelloFib {
  using System;

  class Program {
    private static void Main() {
      while (true) {
        Console.Write("?> ");
        var command = Console.ReadLine().ToLowerInvariant();
        if (command == "quit") {
          break;
        }

        ushort num;
        if (ushort.TryParse(command, out num)) {
          Console.WriteLine($"Fibo[{num}] = {new Fibo(num).Value}");
        }
        else {
          Console.WriteLine("uh?");
        }
      }
    }
  }
}

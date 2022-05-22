using System;

namespace test_console_app {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Hello World!");

      var girl = new Girl {
        Id = 1,
        Name = "Tanya",
        BustSize = 4,
        Age = 40
      };

      Console.WriteLine(girl.Name);
    }
  }
}

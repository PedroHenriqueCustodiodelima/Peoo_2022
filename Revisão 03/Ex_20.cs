using System;
class Program {
  public static void Main() {
    Console.WriteLine($"Resultado: ");
    for (int a = 1; a < 11; a++) {
    Console.Write($"{a} ");
    for (int b = 2; b <= a; b += 2) {
    Console.Write($"{b} ");
    }
      Console.WriteLine();
    }
  }
}
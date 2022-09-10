using System;
class Program {
  public static void Main() {
    int c = 0;
    for (int i = 1; i <= 6; i++) {
      double x = double.Parse(Console.ReadLine());
      if (x > 0) c++;
    }
    Console.WriteLine($"{c} valores positivos");
  }
}

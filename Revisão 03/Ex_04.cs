using System;
class Program {
  public static void Main() {
    int x = 1;
    while (x <= 30) {
      if (x % 3 == 0)
        Console.WriteLine(-x);
      else
        Console.WriteLine(x);
      x++;
    }
  }
}
using System;
class Program {
  public static void Main() {
    int x = 1;
    while (x <= 10) {
      if (x % 2 == 0)
        Console.WriteLine(-x);
      else
        Console.WriteLine(x);
      x++;
    }
  }
}
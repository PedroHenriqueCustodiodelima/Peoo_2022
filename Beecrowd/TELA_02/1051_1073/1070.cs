using System;
class Program {
  public static void Main() {
    int x = int.Parse(Console.ReadLine());
    if (x % 2 == 0){
      x += 1;
    }
    for (int i = 0; i <= 5; i++) {
      Console.WriteLine( x + i * 2);
    }
  }
}
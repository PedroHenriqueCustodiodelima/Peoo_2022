using System;
class Program{
  static void Main(string[] args){
    int x = 0;
    while (x < 100){
      double n = double.Parse(Console.ReadLine());
      if(n <= 10){
        Console.WriteLine($"A[{x}] = {n:0.0}");
      }
      x++;
    }
  }
}

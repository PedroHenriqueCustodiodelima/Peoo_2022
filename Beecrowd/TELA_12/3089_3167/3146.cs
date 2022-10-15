using System;
class Program{
  static void Main(string[] args) {
    double r = double.Parse(Console.ReadLine());
    double x = Math.Round(r * 6.28, 2);
    Console.WriteLine($"{x:0.00}");
  }
}
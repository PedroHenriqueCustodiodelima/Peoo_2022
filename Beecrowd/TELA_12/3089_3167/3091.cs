using System;
class Program{
  static void Main(string[] args) {
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int x = a % b;
    Console.WriteLine(x);
  }
}
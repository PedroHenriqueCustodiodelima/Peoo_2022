using System;
using System.Linq;
class Program{
  static void Main(string[] args) {
    double x = double.Parse(Console.ReadLine());
    if (x >= 0.0000E+00){
      Console.Write("+");
    }
    Console.WriteLine($"{x:0.0000E+00}");
  }
}
using System;
class Program{
  static void Main(string[] args){                             
  double a = double.Parse(Console.ReadLine());
  while (a < 0 || a > 10){
    Console.WriteLine("nota invalida");
    a = double.Parse(Console.ReadLine());
  }
  double b = double.Parse(Console.ReadLine());
  while (b < 0 || b > 10){
    Console.WriteLine("nota invalida");
    b = double.Parse(Console.ReadLine());
  }
  double media = (a + b) / 2.0;
  Console.WriteLine($"media = {media:0.00}");              
  }
}
using System;
class Program{
  static void Main(string[] args){
    int x = 1;
    while (x == 1){
      double n1 = double.Parse(Console.ReadLine());
      while (n1 < 0.0 || n1 > 10.0){
        Console.WriteLine("nota invalida");
        n1 = double.Parse(Console.ReadLine());
      }
      double n2 = double.Parse(Console.ReadLine());
      while (n2 < 0.0 || n2 > 10.0){
        Console.WriteLine("nota invalida");
        n2 = double.Parse(Console.ReadLine());
      }
      double media = (n1 + n2) / 2;
      Console.WriteLine($"media = {media:0.00}");
      Console.WriteLine("novo calculo (1-sim 2-nao)");
      x = int.Parse(Console.ReadLine());
      while (x <1 || x >2){
        Console.WriteLine("novo calculo (1-sim 2-nao)");
        x = int.Parse(Console.ReadLine());
      }
    }
  }
}
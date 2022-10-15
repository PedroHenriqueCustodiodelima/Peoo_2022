using System;        
class Program{
  static void Main(string[] args) {
    string[] v1 = Console.ReadLine().Split(' ');
    double percent1 = double.Parse(v1[0]);
    double percent2 = double.Parse(v1[1]);
    percent1 = percent1 / 100 + 1;
    percent2 = percent2 / 100 + 1;
    double percentAcumulado = ((percent1 * percent2) - 1) * 100;
    Console.WriteLine($"{percentAcumulado:0.000000}");
  }
}
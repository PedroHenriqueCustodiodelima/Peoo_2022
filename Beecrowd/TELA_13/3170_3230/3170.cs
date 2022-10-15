using System;
class Program{
  static void Main(string[] args) {
    int b = int.Parse(Console.ReadLine());
    int g = int.Parse(Console.ReadLine());
    int x = (g / 2) - b;
    if (x <= 0){
      Console.WriteLine("Amelia tem todas bolinhas!");
    }
    else{
      Console.WriteLine($"Faltam {x} bolinha(s)");
    }
  }
}
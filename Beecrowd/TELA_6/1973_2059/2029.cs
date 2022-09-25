using System;
class Program{
  static void Main(string[] args){
    while (true){        
      string a = Console.ReadLine();
      if (string.IsNullOrEmpty(a)){
        break;
      }
      double volume = double.Parse(a);
      double diametro = double.Parse(Console.ReadLine());
      double area = 3.14 * Math.Pow((diametro / 2), 2);
      double altura = volume / area;
      Console.WriteLine($"ALTURA = {altura:0.00}");
      Console.WriteLine($"AREA = {area:0.00}");
    }
  }
}
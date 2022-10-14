using System;
class Program{
static void Main(string[] args){
  string[] n1 = Console.ReadLine().Split(' ');
  double a = double.Parse(n1[0]);
  double b = double.Parse(n1[1]);
  double c = double.Parse(n1[2]);
  double z = Math.Sqrt(b * b - 4 * a * c);
  double x1 = (- b + z) / (2 * a);
  double x2 = (- b - z) / (2 * a);
  if (a == 0 || (b * b - 4 * a * c) < 0){  
    Console.WriteLine("Impossivel calcular");
  }
  else{
    Console.WriteLine($"R1 = {x1:0.00000}");
    Console.WriteLine($"R2 = {x2:0.00000}");
    }
  }
}
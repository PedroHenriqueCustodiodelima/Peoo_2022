using System;
class Program {
  public static void Main() {
    Console.Write("Digite o valor da altura:");
    double x = double.Parse(Console.ReadLine());
    Console.Write("Digite o valor da largura:");
    double y = double.Parse(Console.ReadLine());
    Console.Write("Digite o valor da profundidade:");
    double z = double.Parse(Console.ReadLine());
    Console.WriteLine(VolumeLitros(x,y,z));
  }
  public static double VolumeLitros(double h, double l, double p){
    double a  = h * l * p;
    return a;
  }    
}
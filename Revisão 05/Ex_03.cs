using System;
class Program {
  public static void Main() {
    Console.WriteLine("Digite a diagonal:");
    double x = double.Parse(Console.ReadLine());
    double y = double.Parse(Console.ReadLine());
    Console.WriteLine(Diagonal(x,y));
  }
  public static double Diagonal(double b, double h){
    double a = ((b*b) + (h*h));
    double c = Math.Sqrt(a);
    return c;
    
    }    
}
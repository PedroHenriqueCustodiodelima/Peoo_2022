using System;
class Program {
  public static void Main() {
    Console.WriteLine("Digite dois números");
    double x = double.Parse(Console.ReadLine());
    double y = double.Parse(Console.ReadLine());
    Console.WriteLine(Menor(x,y));
  }
  public static double Menor(double x, double y){
    if (x < y) return x;    
    else{
      return y;
    }    
  }
}

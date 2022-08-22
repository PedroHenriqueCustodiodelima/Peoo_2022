using System;
class Program {
  public static void Main() {
    Console.Write("Digite o valor da massa:");
    double x = double.Parse(Console.ReadLine());
    Console.Write("Digite a distância:");
    double y = double.Parse(Console.ReadLine());;
    Console.WriteLine(Frete(x,y));
  }
  public static double Frete(double massa, double distancia){
    double a  = massa * distancia * 0.1;
    return a;
  }    
}
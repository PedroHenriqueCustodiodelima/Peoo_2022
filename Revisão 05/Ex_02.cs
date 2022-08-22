using System;
class Program {
  public static void Main() {
    Console.WriteLine("Digite a área do circulo");
    double x = double.Parse(Console.ReadLine());
    Console.WriteLine(AreaCirculo(x));
  }
  public static double AreaCirculo(double raio){
    return (raio * raio) * 3.1415;   
    }    
}

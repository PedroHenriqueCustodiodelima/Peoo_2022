using System;
class Program {
  public static void Main() {
    Console.Write("Digite o valor do radio: ");
    double x = double.Parse(Console.ReadLine());
    Console.WriteLine(VolumeEsfera(x));
  }
  public static double VolumeEsfera(double r){
    double volume = 4.0 * 3.1415 * r * r * r/3;
    return volume;
    }    
}
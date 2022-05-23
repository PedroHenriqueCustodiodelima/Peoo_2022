using System;
public class MainClass {
  public static void Main(string[] args) {
    double a, b, a1 = 0, p = 0, d = 0, d1 = 0;
    Console.WriteLine("Digite a base e a altura do retângulo");
    a = double.Parse(Console.ReadLine());
    b = double.Parse(Console.ReadLine());
    a1 = a*b;
    p = a+a+b+b;
    d = ((a*a) + (b*b));
    d1 = Math.Sqrt(d);
    
    Console.WriteLine($"Área = {a1:0.00} - Perímetro = {p:0.00} - Diagonal = {d1:0.00}");
    
  }
}
using System;
public class MainClass {
  public static void Main(string[] args) {
    double a, b, x = 0;
    Console.WriteLine("Digite a nota do primeiro bimestre da disciplina:");
    a = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a nota do segundo bimestre da disciplina:");
    b = double.Parse(Console.ReadLine());
    x = (a+a+b+b+b)/5;
    Console.WriteLine($"Media =" + x);
    
  }
}
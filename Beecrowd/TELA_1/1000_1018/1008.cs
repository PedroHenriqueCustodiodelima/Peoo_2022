using System;
public class MainClass {
  public static void Main(string[] args) {
    int numeros = int.Parse(Console.ReadLine());
    int horas = int.Parse(Console.ReadLine());
    double salario = double.Parse(Console.ReadLine());
    double s1 = horas * salario;
    Console.WriteLine($"NUMBER = {numeros}");
    Console.WriteLine($"SALARY = U$ {s1:0.00}");
    
  }
}
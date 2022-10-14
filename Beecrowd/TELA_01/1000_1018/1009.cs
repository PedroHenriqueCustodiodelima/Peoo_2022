using System;
public class MainClass {
  public static void Main(string[] args) {
    string nome = Console.ReadLine();
    double salario = double.Parse(Console.ReadLine());
    double vendas = double.Parse(Console.ReadLine());
    double comissao = salario + (vendas * 15/100);
    Console.WriteLine($"TOTAL = R$ {comissao:0.00}");
  }
}
using System;
class Program{
  static void Main(string[] args){
  double salario = double.Parse(Console.ReadLine());
  double percentual;
  if (400.0 >=salario){
    percentual = 15.0;
  }
  else if (800.0 >= salario){
    percentual = 12.0;
  }
  else if (1200.0 >= salario){
    percentual = 10.0;
  }
  else if (2000.0 >= salario){
    percentual = 7.0;
  }
  else{
    percentual = 4.0;
  }
  double reajuste = salario * percentual / 100.0;
  double NovoSalario = salario + reajuste;

  Console.WriteLine($"Novo salario: {NovoSalario:0.00}");
  Console.WriteLine($"Reajuste ganho: {reajuste:0.00}");
  Console.WriteLine($"Em percentual: {percentual} %");
    }
}
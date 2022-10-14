using System;
class Program{
  static void Main(string[] args){
    double imposto, porcentagem, a, a1, a2;
    imposto = 0;
    porcentagem = 0;
    double salario = double.Parse(Console.ReadLine());
    if (salario <= 2000){
      Console.WriteLine("Isento");
    }
    else if(salario >= 2000.01 && salario <= 3000){
      a = salario - 2000;
      porcentagem = 8.0 / 100.0;
      imposto = porcentagem * a;
      Console.WriteLine($"R$ {imposto:0.00}");
    }
    else if (salario >= 3000.01 && salario <= 4500){
      a = salario - 2000;
      a1 = a - 1000;
      porcentagem = 8.0 / 100.0;
      imposto = porcentagem * (a - a1);
      porcentagem = 18.0 / 100.0;
      imposto += porcentagem * a1;
      Console.WriteLine($"R$ {imposto:0.00}");
    }
    else if (salario > 4500){
      a = salario - 2000;
      a1 = a - 1000;
      a2 = a1 - 1500;
      porcentagem = 8.0 / 100.0;
      imposto = porcentagem * 1000;
      porcentagem = 18.0 / 100.0;
      imposto += porcentagem * 1500;
      porcentagem = 28.0 / 100.0;
      imposto += porcentagem * a2;
      Console.WriteLine($"R$ {imposto:0.00}");
    }
  }
}
using System;
class Program {
  public static void Main() {
    double soma = 0;
    double quantidade = 0;
    for (int i = 1; i <= 6; i++) {
      double x = double.Parse(Console.ReadLine());
      if (x > 0){
        soma = soma + x;
        quantidade += 1;
      }
    }
    Console.WriteLine($"{quantidade} valores positivos");
    Console.WriteLine($"{soma/quantidade:0.0}");
  }
}
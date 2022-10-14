using System;
class Program{
  static void Main(string[] args){
    int numero;
    double x = 1.0;
    double soma = 0.0;
    for (numero = 1; numero <= 39; numero += 2){
      soma = soma + numero / x;
      x = x * 2.0;
    }
    Console.WriteLine($"{soma:0.00}");
  }
}
using System;
class Program{
  static void Main(string[] args){
    double soma = 0;
    for (int i = 1; i <= 100; i++){
      soma = soma + 1.0 / i;
    }
    Console.WriteLine($"{soma:0.00}");
  }
}
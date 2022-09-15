using System;
class Program{
  static void Main(string[] args){
    double primeiro = 0;
    double segundos = 1;
    double proximo = 0;
    int j = int.Parse(Console.ReadLine());
    for (int i = 1; i <= j; i++, primeiro = 0, segundos = 1){             
      double n = double.Parse(Console.ReadLine());
      n = n + 1;
      for (double p = 0; p < n; p++){
        if (p <= 1) proximo = p;
        else{
          proximo = primeiro + segundos;
          primeiro = segundos;
          segundos = proximo;
        }
      }
        Console.WriteLine($"Fib({n - 1}) = {proximo}");
    }
  }
}
using System;
class Program{
  static void Main(string[] args){
    Console.WriteLine("Digite dois números inteiros:");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int div = a / b;
    int resto = a % b;
    Console.WriteLine($"{a} / {b} = {div}");
    Console.WriteLine($"{a} % {b} = {resto}");
  }
}
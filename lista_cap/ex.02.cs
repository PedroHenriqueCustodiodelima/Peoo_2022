using System;
class Program{
  static void Main(string[] args){
    Console.WriteLine("Digite dois números inteiros:");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int soma = a + b;
    Console.WriteLine($"Soma = {soma}"); 
  }
}
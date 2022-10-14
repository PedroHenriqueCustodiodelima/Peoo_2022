using System;
class Program{
  static void Main(string[] args){
    int idade = int.Parse(Console.ReadLine());
    int anos = idade/365;
    int conta = idade - anos * 365;
    int meses = conta/30;
    int dias = conta - meses * 30;
    Console.WriteLine($"{anos} ano(s)");
    Console.WriteLine($"{meses} mes(es)");
    Console.WriteLine($"{dias} dia(s)");
  }
}
using System;
class Program{
  static void Main(string[] args){
  string[] v = Console.ReadLine().Split(' ');
  double preco1 = double.Parse(v[0]);
  double preco2 = double.Parse(v[1]);
  double dif = preco2 - preco1;
  double porcentagem = (dif * 100) / preco1;
  Console.WriteLine($"{porcentagem:0.00}%");
  }
}
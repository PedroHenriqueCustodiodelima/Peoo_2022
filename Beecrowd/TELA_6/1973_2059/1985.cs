using System;
class Program{
  static void Main(string[] args){
  int produtos = int.Parse(Console.ReadLine());
  double total = 0;
  for (int produto = 0; produto < produtos; produto++){
    string[] linha = Console.ReadLine().Split(' ');
    int codigo = int.Parse(linha[0]);
    int quant = int.Parse(linha[1]);
    switch(codigo){
      case 1001: total += 1.5 * quant; break;
      case 1002: total += 2.5 * quant; break;
      case 1003: total += 3.5 * quant; break;
      case 1004: total += 4.5 * quant; break;
      case 1005: total += 5.5 * quant; break;
    }
  }
  Console.WriteLine($"{total:0.00}");
  }
}
using System;
class Program{
  static void Main(string[] args){
    string[] valores;
    valores = Console.ReadLine().Split(' ');
    int p1 = int.Parse(valores[0]);              
    int t1 = int.Parse(valores[1]);
    double c1 = double.Parse(valores[2]);
    double total = t1 * c1;
    valores = Console.ReadLine().Split(' ');
    int p2 = int.Parse(valores[0]);              
    int t2 = int.Parse(valores[1]);
    double c2 = double.Parse(valores[2]);
    double total1 = t2 * c2;
    double tudo = total + total1;
    Console.WriteLine($"VALOR A PAGAR: R$ {tudo:0.00}");  
  }
}
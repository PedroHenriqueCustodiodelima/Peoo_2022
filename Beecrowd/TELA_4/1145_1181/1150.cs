using System;
class Program{
  static void Main(string[] args){
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    while (b <= a){
      b = int.Parse(Console.ReadLine());
    }
    int c = 1;
    int soma = a;
    do{
      a = a + 1;
      soma = soma + a;
      c = c + 1;
    } while (soma <= b);
      Console.WriteLine(c);
  }
}
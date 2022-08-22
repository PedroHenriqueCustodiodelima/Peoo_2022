using System;
class Program{
  static void Main(string[] args){
    string[] valores;
    valores = Console.ReadLine().Split(' ');
    int primeiro = int.Parse(valores[0]);              
    int segundo = int.Parse(valores[1]);
    int terceiro = int.Parse(valores[2]);
    int maior = primeiro;
    if ( segundo > maior)
      maior = segundo;
    if ( terceiro > maior)
      maior = terceiro;
    Console.WriteLine($"{maior} eh o maior");
  }
}
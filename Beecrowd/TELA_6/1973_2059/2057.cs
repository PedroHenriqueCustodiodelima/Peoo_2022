using System;
class Program{
  static void Main(string[] args){
    string[] v = Console.ReadLine().Split(' ');
    int saida = int.Parse(v[0]);
    int tempo = int.Parse(v[1]);
    int fuso = int.Parse(v[2]);
    int destino = saida + tempo + fuso;
    if (destino > 23){
      destino = destino - 24;
    }
    if (destino < 0){
      destino = destino + 24;
    }
    Console.WriteLine(destino);
  }
}

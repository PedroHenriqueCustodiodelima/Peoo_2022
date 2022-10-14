using System;
class Program{
  static void Main(string[] args){
    string[] v = Console.ReadLine().Split(' ');
    int a = int.Parse(v[1]);
    v = Console.ReadLine().Split(' ');
    int b = int.Parse(v[0]);
    int c = int.Parse(v[2]);
    int d = int.Parse(v[4]);
    v = Console.ReadLine().Split(' ');
    int a1 = int.Parse(v[1]);
    v = Console.ReadLine().Split(' ');
    int b1 = int.Parse(v[0]);
    int c1 = int.Parse(v[2]);
    int d1 = int.Parse(v[4]);
    int inicio = (a - 1) * 24 * 60 * 60 + b * 60 * 60 + c * 60 + d;
    int fim = (a1 - 1) * 24 * 60 * 60 + b1 * 60 * 60 + c1 * 60 + d1;
    int duracao = fim - inicio;

    int w = duracao / (24 * 60 * 60);
    int resto = duracao % (24 * 60 * 60);            
    int x = resto / (60 * 60);
    resto = resto % (60 * 60);
    int y = resto / 60;
    int z = resto % 60;

    Console.WriteLine($"{w} dia(s)");
    Console.WriteLine($"{x} hora(s)");
    Console.WriteLine($"{y} minuto(s)");
    Console.WriteLine($"{z} segundo(s)");
  }
}
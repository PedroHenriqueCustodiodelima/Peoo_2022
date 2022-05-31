using System;
public class MainClass {
  public static void Main(string[] args) {
    int a, b, c, menor = 0, maior = 0;
    Console.WriteLine("Digite quatro valores inteiros"); 
    a = int.Parse(Console.ReadLine());
    b = int.Parse(Console.ReadLine());
    c = int.Parse(Console.ReadLine());
    menor = a;
    maior = a;
    if (b > maior)
    {
      maior = b;
    }
    if (c > maior)
    {
      maior = c;
    }
    if (b < menor)
    {
      menor = b;
    }
    if (c < menor)
    {
      menor = c;
    }
    Console.WriteLine($"A soma do maior com o menor número é {menor+ maior}.");
    }
  }
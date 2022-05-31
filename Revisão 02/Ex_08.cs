using System;
public class MainClass {
  public static void Main(string[] args) {
    int a, b, c, d, menor = 0, maior = 0;
    Console.WriteLine("Digite quatro valores inteiros"); 
    a = int.Parse(Console.ReadLine());
    b = int.Parse(Console.ReadLine());
    c = int.Parse(Console.ReadLine());
    d = int.Parse(Console.ReadLine());
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
    if (d > maior)
    {
      maior =  d;
    }
    Console.WriteLine("Maior = "+ maior);
    if (b < menor)
    {
      menor = b;
    }
    if (c < menor)
    {
      menor = c;
    }
    if (d < menor)
    {
      menor =  d;
    }
    Console.WriteLine("Menor = "+ menor);
    }
  }

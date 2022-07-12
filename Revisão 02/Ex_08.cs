using System;
public class MainClass {
  public static void Main(string[] args) { 
    a = double.Parse(Console.ReadLine());
    b = double.Parse(Console.ReadLine());
    c = double.Parse(Console.ReadLine());
    d = double.Parse(Console.ReadLine());
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

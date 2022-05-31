using System;
public class MainClass {
  public static void Main(string[] args) {
    int a, b, c, d, x = 0, x1 = 0;
    Console.WriteLine("Digite quatro valores inteiros"); 
    a = int.Parse(Console.ReadLine());
    b = int.Parse(Console.ReadLine());
    c = int.Parse(Console.ReadLine());
    d = int.Parse(Console.ReadLine());
    x = 0;
    x1 = 0;
    if (a % 2 == 0)
    {
      x = x + a;
    }
    if (b % 2 == 0)
    {
      x = x + b;
    }
    if (c % 2 == 0)
    {
      x = x + c;
    }
    if (d % 2 == 0)
    {
      x = x + d;
    }
    Console.WriteLine("Soma dos pares = "+x);
    if (a % 2 == 1)
    {
      x1 = x1 + a;
    }
    if (b % 2 == 1)
    {
      x1 = x1 + b;
    }
    if (c % 2 == 1)
    {
      x1 = x1 + c;
    }
    if (d % 2 == 1)
    {
      x1 = x1 + d;
    }
    Console.WriteLine("Soma dos impares = "+x1);
    
    }
  }

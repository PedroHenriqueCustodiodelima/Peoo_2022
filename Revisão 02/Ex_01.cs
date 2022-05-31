using System;
public class MainClass {
  public static void Main(string[] args) {
    int a, b;
    Console.WriteLine("Digite dois valores inteiros");
    a = int.Parse(Console.ReadLine());
    b = int.Parse(Console.ReadLine());
    if ( a > b)
    {
    Console.WriteLine("Maior = " + a);
    }
    else
    {
    Console.WriteLine("Maior = " + b);
    }
    
  }
}
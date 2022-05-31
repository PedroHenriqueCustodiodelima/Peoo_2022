using System;
using System.Linq;

class Program {
    static void Main(string[] args) {
        int a, b, c, x = 0;
        Console.WriteLine("Digite três valores:");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        c = int.Parse(Console.ReadLine());
        if ( a > b)
        {
          x = a;
          a = b;
          b = x;
        }
        if ( a > c)
        {
          x = a;
          a = c;
          c = x;
        }
        if ( b > c)
        {
          x = b;
          b = c;
          c = x;
        }
        Console.WriteLine($"{a}, {b} , {c}");
    }
}
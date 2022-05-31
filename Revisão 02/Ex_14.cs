using System;

class Program {
    static void Main(string[] args) {
        int a, b, c;
        Console.WriteLine("Digite três valores:");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        c = int.Parse(Console.ReadLine());

        if (a+b <= c || a+c <= b || b+c <= a)
        {
        Console.WriteLine("Esses valores não formam um triângulo");
        return;
        }

        if (a != b && a != c && b != c) 
        {
          Console.WriteLine("Escaleno");
        }
        else if (a == b && a == c) 
        {
        Console.WriteLine("Equilátero");
        } 
        else
        {
        Console.WriteLine("Isósceles");
        }
    }
}
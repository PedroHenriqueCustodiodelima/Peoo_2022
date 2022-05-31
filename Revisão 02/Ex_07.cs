using System;
class Program {
    static void Main(string[] args) {
        int a,b, c, delta = 0;
        Console.WriteLine("Digite os coeficientes a, b e c de uma equação do II grau");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        c = int.Parse(Console.ReadLine());
        delta = b*b - 4 * a * c;
        if ( delta < 0 || a == 0)
        {
          Console.WriteLine("impossível calcular");
           return;
        }
        var x1 = (-b + Math.Sqrt(delta))/(2*a);
        var x2 = (-b - Math.Sqrt(delta))/(2*a);
        Console.WriteLine($"As raízes são {x1} e {x2}");
    }
}
using System;
using System.Linq;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Digite uma data no formato dd/mm/aaaa");
        var a = Console.ReadLine().Split('/').Select(int.Parse).ToArray();
        if ( a[0] > 31)
          Console.WriteLine($" A data informada não é válida");
        if ( a[1] > 12)
          Console.WriteLine($" A data informada não é válida");
        if ( a[2] < 1900)
          Console.WriteLine($" A data informada não é válida");
        if ( a[2] > 2100)
          Console.WriteLine($" A data informada não é válida");
    }
}

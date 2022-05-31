using System;
using System.Linq;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Digite uma data no formato dd/mm/aaaa");
        var a = Console.ReadLine().Split('/').Select(int.Parse).ToArray();
      if ( a[1] = 01)
          Console.WriteLine($"A data é {a[0]} de janeiro de {a[2]}");
      if ( a[1] = 02)
          Console.WriteLine($"A data é {a[0]} de fevereiro de {a[2]}");
      if ( a[1] = 03)
          Console.WriteLine($"A data é {a[0]} de março de {a[2]}");
      if ( a[1] = 04)
          Console.WriteLine($"A data é {a[0]} de abril de {a[2]}");
      if ( a[1] = 05)
          Console.WriteLine($"A data é {a[0]} de maio de {a[2]}");
      if ( a[1] = 06)
          Console.WriteLine($"A data é {a[0]} de junho de {a[2]}");
      if ( a[1] = 07)
          Console.WriteLine($"A data é {a[0]} de julho de {a[2]}");
      if ( a[1] = 08)
          Console.WriteLine($"A data é {a[0]} de agosto de {a[2]}");
      if ( a[1] = 09)
          Console.WriteLine($"A data é {a[0]} de setembro de {a[2]}");
      if ( a[1] = 10)
          Console.WriteLine($"A data é {a[0]} de outubro de {a[2]}");
      if ( a[1] = 11)
          Console.WriteLine($"A data é {a[0]} de novembro de {a[2]}");
      if ( a[1] = 12)
          Console.WriteLine($"A data é {a[0]} de dezembro de {a[2]}");
    }
}
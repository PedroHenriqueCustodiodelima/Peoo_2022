using System;
using System.Linq;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Digite o primeiro horário no formato hh:mm");
        var a = Console.ReadLine().Split(':').Select(int.Parse).ToArray();
        
        Console.WriteLine("Digite o segundo horário no formato hh:mm");
        var b = Console.ReadLine().Split(':').Select(int.Parse).ToArray();

        var x1 = a[0] + b[0];
        int x;
        if (a[1] + b[1] > 60) {
            x1 += 1;
            x = Math.Abs(a[1]-b[1]);
        } else {
            x = a[1] + b[1];
        }
        
        Console.WriteLine($"Total de horas = {x1}:{x}");
    }
}
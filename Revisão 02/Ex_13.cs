using System;
using System.Linq;

class Program {
    static void Main(string[] args) {
        int maior = 0, menor = 0;
        Console.WriteLine("Digite dez valores inteiros");
        var x = Console.ReadLine();
        var x1 = x.Split(new Char[] {' '});
        var x2 = int.Parse(x1[0]);
        var x3 = int.Parse(x1[1]);
        var x4 = int.Parse(x1[2]);
        var x5 = int.Parse(x1[3]);
        var x6 = int.Parse(x1[4]);
        var x7 = int.Parse(x1[5]);
        var x8 = int.Parse(x1[6]);
        var x9 = int.Parse(x1[7]);
        var x10 = int.Parse(x1[8]);
        var x11 = int.Parse(x1[9]);
        maior = x2;
        menor = x2;
        if (x3 > maior)
        {
        maior = x3;
        }
        if (x4 > maior)
        {
        maior = x4;
        }
        if (x5 > maior)
        {
        maior =  x5;
        }
        if (x6 > maior)
        {
        maior = x6;
        }
        if (x7 > maior)
        {
        maior = x7;
        }
        if (x8 > maior)
        {
        maior =  x8;
        }
        if (x9 > maior)
        {
        maior = x9;
        }
        if (x10 > maior)
        {
        maior = x10;
        }
        if (x11 > maior)
        {
        maior =  x11;
        }
        if (x3 < menor)
        {
        menor = x3;
        }
        if (x4 < menor)
        {
        menor = x4;
        }
        if (x5 < menor)
        {
        menor =  x5;
        }
        if (x6 < menor)
        {
        menor = x6;
        }
        if (x7 < menor)
        {
        menor = x7;
        }
        if (x8 < menor)
        {
        menor =  x8;
        }
        if (x9 < menor)
        {
        menor = x9;
        }
        if (x10 < menor)
        {
        menor = x10;
        }
        if (x11 < menor)
        {
        menor =  x11;
        }
        Console.WriteLine($"O maior valor é {maior} é o menor é {menor}");
        }
    }
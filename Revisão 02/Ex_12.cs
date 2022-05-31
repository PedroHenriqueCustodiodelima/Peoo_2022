using System;
using System.Linq;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Digite dois valores inteiros separados por um operador +, -, * ou /");
        var a = Console.ReadLine();
        var b = a.Split(new Char[] {'+', '-', '*', '/'});
        var c = int.Parse(b[0]);
        var d = int.Parse(b[1]);
        var x = 0;
        if (a.Contains("+"))
        {
            x = c + d;
        } 
        if (a.Contains("-"))
        {
            x = c - d; 
        } 
        if (a.Contains("*"))
        {
            x = c * d;
        } 
        if (a.Contains("/"))
        {
            x = c / d;
        }
        Console.WriteLine($"O resultado da operação é {x}");
    }
}
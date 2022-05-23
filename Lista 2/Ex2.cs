using System;

    class Program
    {
        static void Main(string[] args)
        {
            
            string[] valores;
            Console.WriteLine("Digite seu nome completo:");
            valores = Console.ReadLine().Split(' ');
            Console.WriteLine($"Bem-vindo ao C#, {valores[0]}");  
        }
    }
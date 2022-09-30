using System;        
class Program{
  static void Main(string[] args) {
    string a = Console.ReadLine();
    string b = Console.ReadLine();
    string c = Console.ReadLine();
    Console.WriteLine($"A = {a}, B = {b}, C = {c}");
    Console.WriteLine($"A = {b}, B = {c}, C = {a}");
    Console.WriteLine($"A = {c}, B = {a}, C = {b}");
  }
}
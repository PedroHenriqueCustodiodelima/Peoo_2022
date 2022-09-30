using System;        
class Program{
  static void Main(string[] args) {
    string[] n = Console.ReadLine().Split('/');
    Console.WriteLine($"{n[1]}/{n[0]}/{n[2]}");
    Console.WriteLine($"{n[2]}/{n[1]}/{n[0]}");
    Console.WriteLine($"{n[0]}-{n[1]}-{n[2]}");
  }
}
using System;        
class Program{
  static void Main(string[] args) {
    string[] n = Console.ReadLine().Split('.');
    int a = int.Parse(n[0]);
    int b = int.Parse(n[1]);
    Console.WriteLine($"{b}.{a}");
  }
}
using System;
class Program{
  static void Main(string[] args){
    string[] v = Console.ReadLine().Split(' ');
    long a = long.Parse(v[0]);
    long b = long.Parse(v[1]);
    long r = a * b;
    Console.WriteLine(r);
  }
}
using System;
class Program{
  static void Main(string[] args) {
    string[] str = Console.ReadLine().Split(' ');
    float n = float.Parse(str[0]);
    float x = float.Parse(str[1]);
    float y = float.Parse(str[2]);
    float c = n / (x + y);
    Console.WriteLine($"{c:0.00}");
  }
}
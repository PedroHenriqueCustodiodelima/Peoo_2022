using System;
class Program{
  static void Main(string[] args){
    string[] v1 = Console.ReadLine().Split(' ');
    int a = int.Parse(v1[0]);              
    int b = int.Parse(v1[1]);
    double x = b / (a + 2.0);
    Console.WriteLine($"{x:0.00}");
  }
}
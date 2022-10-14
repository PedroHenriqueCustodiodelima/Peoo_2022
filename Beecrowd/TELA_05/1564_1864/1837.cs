using System;
class Program{
  static void Main(string[] args){
    string[] v = Console.ReadLine().Split(' ');
    double a = int.Parse(v[0]);
    double b = int.Parse(v[1]);
    double r = a % b;
    if(r < 0) {
      r += Math.Abs(b);
    }   
    double q = (a - r) / b;        
    Console.Write($"{q} ");
    Console.WriteLine(r);
  }
}
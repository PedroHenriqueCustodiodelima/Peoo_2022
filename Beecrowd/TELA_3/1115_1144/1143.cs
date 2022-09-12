using System;
class Program{
  static void Main(string[] args){
    int n = int.Parse(Console.ReadLine());
    for (int i = 1; i <= n; i++){
      double tq =  Math.Pow(i, + 2);
      double tc = Math.Pow(i, + 3);
      Console.WriteLine($"{i} {tq} {tc}");                
    }
  }
}
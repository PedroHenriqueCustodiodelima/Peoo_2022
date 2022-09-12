using System;
class Program{
  static void Main(string[] args){
    int n = int.Parse(Console.ReadLine());
    int p1 = 1;           
    for (int i = 1; i <= n; i++){
      int p2 = p1 + 1;
      int p3 = p1 + 2;
      Console.WriteLine($"{p1} {p2} {p3} PUM");
      p1 = p1 + 4;
    }
  }
}
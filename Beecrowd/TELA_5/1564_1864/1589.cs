using System;
class Program{
  static void Main(string[] args){
    int n = int.Parse(Console.ReadLine());
    for(int i = 0; i < n; i++){
      string[] v = Console.ReadLine().Split(' ');
      int r1 = int.Parse(v[0]);
      int r2 = int.Parse(v[1]);
      int t = r1 + r2;
      Console.WriteLine(t);
    }
  }
}
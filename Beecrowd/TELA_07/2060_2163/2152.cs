using System;        
class Program{
  static void Main(string[] args) {
    int n = int.Parse(Console.ReadLine());
    for (int i = 0; i < n; i++) {
      string[] v = Console.ReadLine().Split(' ');
      int h = int.Parse(v[0]);
			int m = int.Parse(v[1]);
      int o = int.Parse(v[2]);
      Console.Write($"{h:00}:{m:00} - A porta ");
      Console.WriteLine((o == 1) ? "abriu!" : "fechou!");
    }
  }
}
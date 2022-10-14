using System;
using System.Linq;          
class Program{
  static void Main(string[] args) {
    string a = Console.ReadLine();
    while (!string.IsNullOrEmpty(a)){
      string[] v = a.Split(' ');
      int.TryParse(v[0], out int n);
      int.TryParse(v[1], out int q);
      int[] p = new int[n];
      for (int i = 0; i < n; i++){
        int.TryParse(Console.ReadLine(), out p[i]);
      }
      p = p.OrderByDescending(x => x).ToArray();
      for (int j = 0; j < q; j++){
        int posicao = int.Parse(Console.ReadLine());
        Console.WriteLine(p[posicao - 1]);
      }
      a = Console.ReadLine();
    }
  }
}
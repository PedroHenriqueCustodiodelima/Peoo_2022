using System;        
class Program{
  static void Main(string[] args) {
    string a = Console.ReadLine();
    while (!string.IsNullOrEmpty(a)){
      int n = int.Parse(Console.ReadLine());
      string[] v = Console.ReadLine().Split(' ');
      for (int i = 0; i < n; i++){
        int.TryParse(v[i], out int l);
        Console.Write(a[l - 1]);
      }
      Console.WriteLine();
      a = Console.ReadLine();
    }
  }
}
using System;
class Program{
  static void Main(string[] args) {
    int n = int.Parse(Console.ReadLine());
    for (int i = 0; i < n; i++){
      string[] x = Console.ReadLine().Split(' ');
      int x0 = int.Parse(x[0]);
      int x1 = int.Parse(x[1]);
      int x2 = int.Parse(x[2]);
      if (x0 >= 200 && x0 <= 300 && x1 >= 50 && x2 >= 150)
        Console.WriteLine("Sim");
      else
        Console.WriteLine("Nao");
    }
  }
}
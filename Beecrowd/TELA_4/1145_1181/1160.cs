using System;
class Program{
  static void Main(string[] args){
    int p = 0;
    int q = 0;
    int t = int.Parse(Console.ReadLine());
    for (int i = 0; i < t; i++){
      string[] inputValue = Console.ReadLine().Split();
      int pa = int.Parse(inputValue[0]);
      int pb = int.Parse(inputValue[1]);
      double g1 = double.Parse(inputValue[2]);
      double g2 = double.Parse(inputValue[3]);
      int d = pa;
      int e = pb;
      int n = 0;
      while (p <= q){
        p = (int)(d + d * (g1 / 100));
        q = (int)(e + e * (g2 / 100));
        d = p;
        e = q;
        n++;
        if (n > 100){
          break;
        }
      }
      if (n > 100){
        Console.WriteLine("Mais de 1 seculo.");
      }
      else{
        Console.WriteLine("{0} anos.", n);
      }
      p = 0;
      q = 0;
    }
  }
}
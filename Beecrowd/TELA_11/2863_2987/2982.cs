using System;       
class Program{
  static void Main(string[] args) {
    int G = 0, V = 0;
    int n = int.Parse(Console.ReadLine());
    while (n > 0){
      string[] v = Console.ReadLine().Split(' ');
      if (v[0] == "G"){
        G += int.Parse(v[1]);
      }
      else{
        V += int.Parse(v[1]);
      }
        n--;
      }
      if (V >= G){
        Console.WriteLine("A greve vai parar.");
      }
      else{
        Console.WriteLine("NAO VAI TER CORTE, VAI TER LUTA!");
    }
  }
}
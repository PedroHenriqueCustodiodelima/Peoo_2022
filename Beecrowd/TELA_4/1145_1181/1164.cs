using System;
class Program{
  static void Main(string[] args){
    int n = int.Parse(Console.ReadLine());
    for (int i = 0; i < n; i++){    
      int k = 0;
      int x = int.Parse(Console.ReadLine());
      for (int p = 1; p < x; p++){
        if (x % p == 0){
          k += p;
        }
      }
      if (k == x){
        Console.WriteLine($"{x} eh perfeito");
      }
      else {
        Console.WriteLine($"{x} nao eh perfeito");
      }
    }
  }
}
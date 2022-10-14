using System;
class Program{
  static void Main(string[] args){
    string[] n = Console.ReadLine().Split(' ');
    int x = int.Parse(n[0]);           
    int y = int.Parse(n[1]);           
    while (x != y){
      if (x < y){
        Console.WriteLine("Crescente");
      }
      else{
        Console.WriteLine("Decrescente");
      }
      n = Console.ReadLine().Split(' ');
      x = int.Parse(n[0]);
      y = int.Parse(n[1]);
    }
  }
}
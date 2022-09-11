using System;
class Program{
  static void Main(string[] args){
    string[] v = Console.ReadLine().Split(' ');
    int x = int.Parse(v[0]);
    int y = int.Parse(v[1]);
    while ( x != 0 && y != 0){
      if (x > 0 && y > 0){
        Console.WriteLine("primeiro");
      }
      else if (x < 0 && y > 0){
        Console.WriteLine("segundo");
      }
      else if (x < 0 && y < 0){
        Console.WriteLine("terceiro");
      }
      else{
        Console.WriteLine("quarto");
      }
      v = Console.ReadLine().Split(' ');
      x = int.Parse(v[0]);
      y = int.Parse(v[1]);
    }           
  }
}
using System;
class Program{
  static void Main(string[] args){
    string[] v = Console.ReadLine().Split(' ');
    int a = int.Parse(v[0]);
    int b = int.Parse(v[1]);
    int c = int.Parse(v[2]);
    if((a - b == 0) || (a - c == 0) || (b - c == 0)){
      Console.WriteLine("S");
    }
    else{
      if((a + b - c == 0) || (b - a + c == 0) || (c - a + b == 0)){
        Console.WriteLine("S");
      }
      else if((a - b - c == 0) || (b - a - c == 0) || (c - a - b == 0)){
        Console.WriteLine("S");
      }
      else{
        Console.WriteLine("N");
      }
    }
  }       
}
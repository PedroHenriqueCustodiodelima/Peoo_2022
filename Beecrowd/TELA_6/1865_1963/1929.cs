using System;
class Program{
  static void Main(string[] args){
    string[] v = Console.ReadLine().Split(' ');
    int p = int.Parse(v[0]);
    int q = int.Parse(v[1]);
    int r = int.Parse(v[2]);
    int s = int.Parse(v[2]);
      if(p + q >= r && q + r >= p && r + p >= q){
        Console.WriteLine("S");
      }
      else if(p + q >= s && q + s >= p && s + p >= q){
        Console.WriteLine("S");
      }
      else if(p + s >= r && s + r >= p && r + p >= s){
        Console.WriteLine("S");
      }
      else if(s + q >= r && q + r >= s && r + s >= q){
        Console.WriteLine("S");
      }
      else{
      Console.WriteLine("N");
    }
  }
}
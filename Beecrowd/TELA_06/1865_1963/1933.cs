using System;
class Program{
  static void Main(string[] args){
  string[] v = Console.ReadLine().Split(' ');
  int a = int.Parse(v[0]);
  int b = int.Parse(v[1]);
  if(a == b){
    Console.WriteLine(a);
  }
  else{
    if(a > b){
      Console.WriteLine(a);
    }
    else{
      Console.WriteLine(b);
      }
    }
  }
}
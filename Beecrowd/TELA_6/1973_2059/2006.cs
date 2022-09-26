using System;
class Program{
  static void Main(string[] args){
    int x = 0;
    int a = int.Parse(Console.ReadLine());
    string[] v = Console.ReadLine().Split(' ');
    for (int i = 0; i < 5; i++){
      int b = int.Parse(v[i]);
      if (b == a){
      x++;
      }
    }
    Console.WriteLine(x);
  }
}
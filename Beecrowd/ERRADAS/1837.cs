using System;
class Program{
  static void Main(string[] args){
    int r, q;
    string[] v = Console.ReadLine().Split(' ');
    int a = int.Parse(v[0]);
    int b = int.Parse(v[1]);
    q = a / b;
    r = a % b;
    if(r < 0){
      if(q > 0){
        q++;
      }
      if(q < 0){
        q--;
        r = a - (q * b);
      }
    }
    Console.WriteLine($"{q} {r}");
  }       
}
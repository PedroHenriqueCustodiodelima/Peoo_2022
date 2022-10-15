using System;
class Program{
  static void Main(string[] args) {
    int m = int.Parse(Console.ReadLine());
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int x = m - a - b;
    if(x > a && x > b){
      Console.WriteLine(x);
    }
    else if (a > b && a > x){
      Console.WriteLine(a);
    }
    else{
      Console.WriteLine(b);
    }
  }
}
using System;
class Program{
  static void Main(string[] args){
    int x = 0;
    int a = int.Parse(Console.ReadLine());
    while (x < a){
      Console.Write("Ho");
        if (x != a-1){
          Console.Write(" ");
        }
        else{
          Console.WriteLine("!");
        }
        x++;
    }
  }
}
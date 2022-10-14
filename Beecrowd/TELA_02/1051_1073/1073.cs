using System;
class Program{
  static void Main(string[] args){
    int x = int.Parse(Console.ReadLine());
    for(int i = 2; i <= x; i += 2){
      Console.WriteLine(i+ "^2 = " + i*i);
      }
  }
}
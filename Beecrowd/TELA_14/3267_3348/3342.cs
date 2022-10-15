using System;        
class Program{
  static void Main(string[] args) {
    int a = 0 , b = 0;
    int c = int.Parse(Console.ReadLine().Trim());
    int boardSize = (c * c);
    a += (boardSize % 2) + (boardSize / 2);
    b += (boardSize / 2);
    Console.WriteLine("{0} casas brancas e {1} casas pretas", a,b);
  }
}
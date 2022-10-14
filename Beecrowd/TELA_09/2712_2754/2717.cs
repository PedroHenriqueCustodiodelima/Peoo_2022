using System;        
class Program{
  static void Main(string[] args) {
		int n = int.Parse(Console.ReadLine());
    string[] v = Console.ReadLine().Split(' ');
    int a = int.Parse(v[0]);
		int b = int.Parse(v[1]);
    Console.WriteLine(a + b <= n ? "Farei hoje!" : "Deixa para amanha!");
  }
}
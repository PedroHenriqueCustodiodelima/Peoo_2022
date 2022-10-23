using System; 
class Program{
  static void Main(string[] args) {
    int n = int.Parse(Console.ReadLine());
    int domino = (n + 1) * (n + 2) / 2;
    Console.WriteLine(domino);
  }
}
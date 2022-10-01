using System; 
class Program{
  static void Main(string[] args) {
    int c = int.Parse(Console.ReadLine());
    int l = int.Parse(Console.ReadLine());
    int calc1 = (l * c) + ((l - 1) * (c - 1));
    int calc2 = ((l - 1) * 2) + ((c - 1) * 2);
    Console.WriteLine(calc1);
    Console.WriteLine(calc2);
  }
}
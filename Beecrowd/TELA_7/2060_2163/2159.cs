using System; 
class Program{
  static void Main(string[] args) {
    int n = int.Parse(Console.ReadLine());
    double x = n / Math.Log(n);
    double a = x * 1.25506;
    Console.WriteLine($"{x:0.0} {a:0.0}");
  }
}
using System; 
class Program{
  static void Main(string[] args) {
    int n = int.Parse(Console.ReadLine()); 
    double x = (1 + Math.Sqrt(5))/2.0;
    double y = (1 - Math.Sqrt(5))/2.0;
    double ans = (Math.Pow(x,n) - Math.Pow(y,n))/Math.Sqrt(5);
    Console.WriteLine($"{ans:0.0}");
  }
}
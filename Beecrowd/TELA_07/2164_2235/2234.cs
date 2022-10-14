using System; 
class Program{
  static void Main(string[] args) {
    string[] v = Console.ReadLine().Split();
    int part = int.Parse(v[0]);
    int coxinhas = int.Parse(v[1]);
    double media = (double)part / coxinhas;
    Console.WriteLine($"{media:0.00}");
  }
}
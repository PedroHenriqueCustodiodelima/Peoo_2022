using System; 
class Program{
  static void Main(string[] args) {
    int c = int.Parse(Console.ReadLine());
    for (int i = 0; i < c; i++){
      string a = Console.ReadLine();
      double t = a.Length;
      double x = t / 100;
      Console.WriteLine($"{x:0.00}");
    }
  }
}
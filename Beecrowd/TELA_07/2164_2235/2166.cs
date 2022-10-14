using System; 
class Program{
  static void Main(string[] args) {
    int n = int.Parse(Console.ReadLine());
    double x = 0;
    for (int i = 0; i < n; i++){
      x += 2.0;
      x = 1.0 / x;
    }
    x++;
     Console.WriteLine($"{x:0.0000000000}");
  }
}
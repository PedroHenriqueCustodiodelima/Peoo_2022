using System; 
class Program{
  static void Main(string[] args) { 
    int x = int.Parse(Console.ReadLine());
    for (int i = 0; i < x; i++){
      string[] v = Console.ReadLine().Split();
      int n = int.Parse(v[0]);
      int k = int.Parse(v[1]);
      Console.WriteLine((n % k) + (n / k));
    }
  }
}
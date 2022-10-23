using System; 
class Program{
  static void Main(string[] args) {
    int N = int.Parse(Console.ReadLine());
    double resposta = (Math.Pow(N, 4.0)-(6.0 * Math.Pow(N, 3.0))+(23.0 * Math.Pow(N, 2.0))-(18.0 * N)+24.0)/24.0;
    Console.WriteLine(resposta);
  }
}
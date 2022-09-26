using System; 
class Program{
  static void Main(string[] args) {
    int n = int.Parse(Console.ReadLine());
    double cont = 0;
    for (int i = 0; i < n; i++){
      cont += 6.0;
      cont = 1.0 / cont;
    }
    cont += 3.0;
    Console.WriteLine($"{cont:0.0000000000}");
  }
}
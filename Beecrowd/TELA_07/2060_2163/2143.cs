using System; 
class Program{
  static void Main(string[] args) {
    string str;
    while ((str = Console.ReadLine()) != "0"){
      int t = int.Parse(str);
      for (int i = 0; i < t; i++){
        int n = int.Parse(Console.ReadLine());
        int pedidos = (n - 1) % 2 == 0 ? (2 * n) - 1 : (2 * n) - 2;
        Console.WriteLine(pedidos);
      }
    }
  }
}
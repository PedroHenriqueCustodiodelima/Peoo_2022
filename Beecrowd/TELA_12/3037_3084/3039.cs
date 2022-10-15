using System;       
class Program{
  static void Main(string[] args) {
    int n = int.Parse(Console.ReadLine());
    int bonecas = 0, carros = 0;
    for (int i = 0; i < n; i++){
      string[] g = Console.ReadLine().Split(' ');
      string x = g[1];
      if (x == "M"){
        ++carros;
      }
      else{
        ++bonecas;
      }
    }
    Console.WriteLine($"{carros} carrinhos");
    Console.WriteLine($"{bonecas} bonecas");
  }
}
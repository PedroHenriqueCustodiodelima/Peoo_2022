using System;
class Program{
  static void Main(string[] args) {
    int vitorias = 0;
    int n = int.Parse(Console.ReadLine());
    for (int i = 0; i < n; i++){
      int carro = int.Parse(Console.ReadLine());
      if (carro != 1){
        vitorias++;
      }
    }
    Console.WriteLine(vitorias);
  }
}
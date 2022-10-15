using System;
class Program{
  static void Main(string[] args) {
    int n = int.Parse(Console.ReadLine());
    int[] votos = new int[n];
    bool eleito = true;
    for (int i = 0; i < n; i++){
      int.TryParse(Console.ReadLine(), out votos[i]);
      if (votos[i] > votos[0]){
        eleito = false;
      }
    }
    Console.WriteLine(eleito ? "S" : "N");
  }
}
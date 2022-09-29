using System;        
class Program{
  static void Main(string[] args) {
		int turistas = 0;
    int veiculos = 0;
    string[] v = Console.ReadLine().Split(' ');
    while (v[0] != "ABEND"){
      if (v[0] == "SALIDA"){
        veiculos++;
        turistas += int.Parse(v[1]);
      }
      else{
        veiculos--;
        turistas -= int.Parse(v[1]);
      }
      v = Console.ReadLine().Split(' ');
    }
    Console.WriteLine(turistas);
    Console.WriteLine(veiculos);
  }
}
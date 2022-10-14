using System;
class Program{
  static void Main(string[] args){
    int VitoriasInter = 0;
    int VitoriasGremio = 0;
    int empate = 0;
    int novoGrenal = 1;
    while (novoGrenal == 1){
      string[] valores = Console.ReadLine().Split(' ');
      int golsInter = int.Parse(valores[0]);
      int golsGremio = int.Parse(valores[1]);
      if (golsInter > golsGremio){
        VitoriasInter = VitoriasInter + 1;
      }
      else if ( golsGremio > golsInter){
        VitoriasGremio = VitoriasGremio + 1;
      }
      else{
        empate = empate + 1;
      }
        Console.WriteLine("Novo grenal (1-sim 2-nao)");
        novoGrenal = int.Parse(Console.ReadLine());
      }
      int total = VitoriasGremio + VitoriasInter + empate;
      Console.WriteLine(total + " grenais");
      Console.WriteLine("Inter:" + VitoriasInter);
      Console.WriteLine("Gremio:" + VitoriasGremio);
      Console.WriteLine("Empates:" + empate);
      if (VitoriasInter > VitoriasGremio){
        Console.WriteLine("Inter venceu mais");
      }
      else if ( VitoriasGremio > VitoriasInter){
        Console.WriteLine("Gremio venceu mais");
      }
      else{
        Console.WriteLine("Não houve vencedor");
    }
  }
}
using System;
class Program{
  static void Main(string[] args){
    int n = int.Parse(Console.ReadLine());
    for (int i = 0; i < n; i++){
      string jogador1 = Console.ReadLine();
      string jogador2 = Console.ReadLine();
      if (jogador1 == "papel"){
        if (jogador2 == "papel"){
          Console.WriteLine("Ambos venceram");
        }
        else{
          Console.WriteLine("Jogador 2 venceu");
        }
      }
      else if (jogador1 == "pedra"){
        if (jogador2 == "papel"){
          Console.WriteLine("Jogador 1 venceu");
        }
        else if (jogador2 == "pedra"){
          Console.WriteLine("Sem ganhador");
        }
        else{
          Console.WriteLine("Jogador 2 venceu");
        }
      }
      else{
        if (jogador2 == "papel" || jogador2 == "pedra"){
          Console.WriteLine("Jogador 1 venceu");
        }
        else{
          Console.WriteLine("Aniquilacao mutua");
        }
      }
    }
  }
}
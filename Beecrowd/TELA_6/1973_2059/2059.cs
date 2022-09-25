using System;
class Program{
  static void Main(string[] args){
    string[] v = Console.ReadLine().Split(' ');
    int p = int.Parse(v[0]);
    int j1 = int.Parse(v[1]);
    int j2 = int.Parse(v[2]);
    int r = int.Parse(v[3]);
    int a = int.Parse(v[4]);
    int total = j1 + j2;
      if (r == 1){
        if (a == 1){
          Console.WriteLine("Jogador 2 ganha!");
        }
        else{
          Console.WriteLine("Jogador 1 ganha!");
        }
      }
      else{
        if (a == 1){
          Console.WriteLine("Jogador 1 ganha!");
        }
        else{
          if (p == 1){
            if (total % 2 == 0){
              Console.WriteLine("Jogador 1 ganha!");
            }
            else{
               Console.WriteLine("Jogador 2 ganha!");
              }
            }
          else{
            if (total % 2 != 0){
              Console.WriteLine("Jogador 1 ganha!");
            }
            else{
               Console.WriteLine("Jogador 2 ganha!");
          }
        }
      }
    }
  }
}
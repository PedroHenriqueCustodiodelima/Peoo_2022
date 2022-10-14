using System;
class Program{
  static void Main(string[] args){
  bool ganhar = true;
  string[] linha1 = Console.ReadLine().Split(' ');
  int pulo = int.Parse(linha1[0]);
  int canos = int.Parse(linha1[1]);
  string[] linha2 = Console.ReadLine().Split(' ');
  int[] alturas;
  alturas = new int[canos];
  for(int i = 0; i < canos; i++){
    alturas[i] = int.Parse(linha2[i]);
  }
  for(int i = 0; i < canos - 1; i++){
    if (Math.Abs(alturas[i+1] - alturas[i]) > pulo){
      ganhar = false;
     }
    }
    if (ganhar){
      Console.WriteLine("YOU WIN");
    }
    else{
      Console.WriteLine("GAME OVER");
    }           
  }
}
using System;
class Program{
  static void Main(string[] args){
  string [] x = Console.ReadLine().Split(' ');
  int hi = int.Parse(x[0]);
  int hf = int.Parse(x[1]);
  if ( hf > hi){
    int dj = hf - hi;
    Console.WriteLine($"O JOGO DUROU {dj} HORA(S)");
  } 
  else{
    int dj = (24 - hi) + hf;
    Console.WriteLine($"O JOGO DUROU {dj} HORA(S)");
    }
  }
}
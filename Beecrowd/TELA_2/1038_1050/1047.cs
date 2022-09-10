using System;
class Program{
  static void Main(string[] args){
  string [] v = Console.ReadLine().Split(' ');
  int hi  = int.Parse(v[0]);
  int mi  = int.Parse(v[1]);
  int hf  = int.Parse(v[2]);
  int mf  = int.Parse(v[3]);
  int i = mi + (hi * 60);
  int f = mf + (hf * 60);
  int tempo;
  if (f > i){
    tempo = f - i;
  }
  else{
    tempo = (24 * 60 - i) + f;
  }
  int dh = tempo / 60;
  int dm = tempo % 60;
  Console.WriteLine($"O JOGO DUROU {dh} HORA(S) E {dm} MINUTO(S)");
  }
}
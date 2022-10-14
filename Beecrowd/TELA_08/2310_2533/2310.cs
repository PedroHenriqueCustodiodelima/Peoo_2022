using System;
class Program{
  static void Main(string[] args){
    int quan = int.Parse(Console.ReadLine());
    int somaS1 = 0, somaB1 = 0, somaA1 = 0, somaS2 = 0, somaB2 = 0, somaA2 = 0;
    for (int i = 0; i < quan; i++){
      string nome = Console.ReadLine();
      string[] jogada1 = Console.ReadLine().Split();
      string[] jogada2 = Console.ReadLine().Split();
      int saque = int.Parse(jogada1[0]);
      int bloqueio = int.Parse(jogada1[1]);
      int ataque = int.Parse(jogada1[2]);
      int saque2 = int.Parse(jogada2[0]);
      int bloqueio2 = int.Parse(jogada2[1]);
      int ataque2 = int.Parse(jogada2[2]);
      somaS1 += saque;
      somaB1 += bloqueio;
      somaA1 += ataque;
      somaS2 += saque2;
      somaB2 += bloqueio2;
      somaA2 += ataque2;
      }
    Console.WriteLine("Pontos de Saque: {0:0.00} %.", ((double)somaS2 / somaS1) * 100.0);
    Console.WriteLine("Pontos de Bloqueio: {0:0.00} %.", ((double)somaB2 / somaB1) * 100);
    Console.WriteLine("Pontos de Ataque: {0:0.00} %.", ((double)somaA2 / somaA1) * 100);
    }
}
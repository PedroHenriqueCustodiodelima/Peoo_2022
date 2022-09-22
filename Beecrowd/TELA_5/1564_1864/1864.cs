using System;
class Program {
  static void Main(string[] args) {
    string frase = "LIFE IS NOT A PROBLEM TO BE SOLVED";
    int posicao = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(frase.Substring(0, posicao));
  }
}
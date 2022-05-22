using System;
public class MainClass {
  public static void Main(string[] args) {
    Console.WriteLine("Digite seu nome completo:");
    string s = Console.ReadLine();
    var nome = s.Split(' ');
    string nome1 = nome[0];
    Console.WriteLine("Bem-vindo ao C#," + nome1);
    
  }
}
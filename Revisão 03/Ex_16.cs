using System;
class Program {
  public static void Main() {
    Console.WriteLine("Digite uma frase: ");
    string a = Console.ReadLine();
    string[] vogais = {"A", "E", "I", "O", "U"};
    foreach (string i in vogais) {
    Console.WriteLine($"{i} - {a.ToUpper().Split(i).Length}");
    }
  }
}
using System;
class Program{
  static void Main(string[] args){
    Console.WriteLine("Digite uma frase:");
    var a = Console.ReadLine();
    for (int i = 1; i <= a.Length; i++){
      Console.WriteLine($"{i} - {a}");
    }
  }
}
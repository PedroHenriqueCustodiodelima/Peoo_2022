using System;
class Program {
  static void Main(string[] args){    
    Console.WriteLine("Digite uma frase:");
    var a = Console.ReadLine().Split();
    foreach (string i in a){    
      Console.Write(i[i.Length-1]);
    }
  }
}
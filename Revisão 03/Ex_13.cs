using System;
class Program {
  public static void Main() {    
    Console.WriteLine("Digite uma frase: ");
    var a = Console.ReadLine();
    var b = a.ToCharArray(); Array.Reverse(b);
    Console.WriteLine(new string(b));
    }
}
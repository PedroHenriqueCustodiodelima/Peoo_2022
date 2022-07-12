using System;
class Program {
  public static void Main() {
    Console.WriteLine("Digite uma frase: ");
    var a = Console.ReadLine().Split();
    for (int i = 0; i < a.Length; i++) {
    var b = a[i].ToCharArray(); Array.Reverse(b);
    Console.WriteLine(new string(b));
    }   
  }
}
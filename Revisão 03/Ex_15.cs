using System;
class Program {
  public static void Main() {
    Console.WriteLine("Digite uma frase: ");
    var a = Console.ReadLine().Split();
    for (int i = 0; i < a.Length; i++) {
    Console.Write(a[i].Length);
    }
  }
}
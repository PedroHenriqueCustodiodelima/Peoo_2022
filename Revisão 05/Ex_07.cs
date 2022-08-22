using System;
class Program {
  public static void Main() {
    Console.Write("Digite um valor:");
    int z = int.Parse(Console.ReadLine());
    int v, w;
    AntecessorSucessor(z, out v, out w);
    Console.WriteLine(v);
    Console.WriteLine(w);
  }
  public static void AntecessorSucessor (int x, out int antecessor, out int sucessor){
    antecessor = x - 1;
    sucessor = x + 1;
  }    
}
using System;
class Program{
  static void Main(string[] args){
    int[] x = new int[10];
    for (int i = 0; i < x.Length; i++){
      int valor = int.Parse(Console.ReadLine());
      if (valor == 0 || valor < 0)
        valor = 1;
        x[i] = valor;
      }
      for (int i = 0; i < x.Length; i++){
        Console.WriteLine("X[{0}] = {1}", i, x[i]);
    }
  }
}
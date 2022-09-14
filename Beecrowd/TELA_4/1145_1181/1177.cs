using System;
internal class Program{
  static void Main(string[] args){
    int[] N = new int[1000];
    int j = 0;
    int n = int.Parse(Console.ReadLine());
    for (int i = 0; i < 1000; i++){
      Console.WriteLine("N[{0}] = {1}", i, j);
      j++;
      if (j == n) {
          j = 0;
      }            
    }
  }
}
using System;
class Program{
  static void Main(string[] args){
    int i = 0;
    int c = 0;
    int[] vetor;
    vetor = new int[13];
    int fatorial = 0;
    int n = int.Parse(Console.ReadLine());
    while (n > 13){
      n = int.Parse(Console.ReadLine());
    }
    for (c = n; c > 0; c--){
      if (i == 0){
        i = 1;
        fatorial = c;
      }
      else{
        fatorial = fatorial * c;
      }
    }
    Console.WriteLine(fatorial);
  }
}
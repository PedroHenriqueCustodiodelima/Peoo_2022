using System;
class Program{
  static void Main(string[] args){
    int n = int.Parse(Console.ReadLine());        
    for (int i = 0; i <= 10000; i++){
      int resto = 0;
      resto = i % n;
      if (resto == 2){
        Console.WriteLine(i);
      }
     }
  }
}
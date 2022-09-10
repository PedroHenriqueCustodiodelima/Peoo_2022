using System;
class Program{
  static void Main(string[] args){
    int n = int.Parse(Console.ReadLine());
    int dentro = 0;
    int fora = 0;
    for (int i = 0; i < n; i++){
      int x = int.Parse(Console.ReadLine());
      if (x >= 10 && x <= 20){
        dentro = dentro + 1;
      }
      else{
        fora = fora + 1;
      }
    }
    Console.WriteLine(dentro + " in");
    Console.WriteLine(fora + " out");
  }
}
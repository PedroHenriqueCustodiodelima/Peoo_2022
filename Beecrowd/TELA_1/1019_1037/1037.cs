using System;
class Program{
static void Main(string[] args){
  double a = double.Parse(Console.ReadLine());
  if ( a >= 0 && a <= 100){
      if (a <= 25){
        Console.WriteLine("Intervalo [0,25]");
      }
      else if (a <= 50){
        Console.WriteLine("Intervalo (25,50]");
      }
      else if (a <= 75){
        Console.WriteLine("Intervalo (50,75]");
      }
      else{
        Console.WriteLine("Intervalo (75,100]");
    }
  }
  else{
      Console.WriteLine("Fora de intervalo");
    }
  }
}
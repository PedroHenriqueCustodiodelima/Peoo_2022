using System;
class Program{
  static void Main(string[] args){
  int cont = 0;
  int a = int.Parse(Console.ReadLine());
  while (cont < a){
    int n = int.Parse(Console.ReadLine());
    if(n % 2 == 0){
      Console.WriteLine("0");
    }
    else{
      Console.WriteLine("1");
    }
    cont++;
    }
  }
}
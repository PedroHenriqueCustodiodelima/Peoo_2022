using System;
class Program{
static void Main(string[] args){
  int a = int.Parse(Console.ReadLine());
  for (int i = 0; i < a; i++){
    string[] vet = Console.ReadLine().Split(' ');
    int x = int.Parse(vet[0]);
    int y = int.Parse(vet[1]);
    if (y == 0){
      Console.WriteLine("divisao impossivel");
    }
    else{
      double div = (double)x / y;
      Console.WriteLine($"{div:0.0}");
      }
    }
  }
}
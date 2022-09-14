using System;
class Program{
  static void Main(string[] args){
    string[] vet = Console.ReadLine().Split(' ');
    int x = int.Parse(vet[0]);
    int y = int.Parse(vet[1]);
    for (int i = 1; i <= y; i++){
      Console.Write(i);
      if (i % x == 0){
        Console.WriteLine();
      }
      else{
        Console.Write(" ");
      }
    }
  }
}
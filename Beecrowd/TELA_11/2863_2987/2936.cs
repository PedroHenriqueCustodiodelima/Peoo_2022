using System;
class Program{
  static void Main(string[] args){
    int qtdMandioca = 0;
    int[] gramaSer = new int[] { 300, 1500, 600, 1000, 150, 225 };
    for (int x = 0; x < 5; x++){
      qtdMandioca += int.Parse(Console.ReadLine()) * gramaSer[x];
    }
    Console.WriteLine(qtdMandioca + gramaSer[5]);
  }
}
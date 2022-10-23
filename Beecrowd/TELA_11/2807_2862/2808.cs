using System;
class Program{
  static void Main(string[] args){
    string[] valores = Console.ReadLine().Split(' ');
    string casa1 = valores[0];
    string casa2 = valores[1];
    if(casa1[0]+2 == casa2[0] || casa1[0]-2 == casa2[0]){
      if(casa1[1]+1 == casa2[1] || casa1[1]-1 == casa2[1]){
        Console.WriteLine("VALIDO");
      }
      else{
        Console.WriteLine("INVALIDO");
      }
    }
    else{
      if(casa1[0]+1 == casa2[0] || casa1[0]-1 == casa2[0]){
        if(casa1[1]+2 == casa2[1] || casa1[1]-2 == casa2[1]){
          Console.WriteLine("VALIDO");
        }
        else{
          Console.WriteLine("INVALIDO");
        }
      }
      else{
        Console.WriteLine("INVALIDO");
      }
    }
  }
}
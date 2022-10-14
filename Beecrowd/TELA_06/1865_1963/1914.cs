using System;
class Program{
  static void Main(string[] args){
  int quant = int.Parse(Console.ReadLine());
   for (int jogos = 0; jogos < quant; jogos++){
    string[] escolhas = Console.ReadLine().Split(' ');
    string[] valores = Console.ReadLine().Split(' ');
    int a = int.Parse(valores[0]);
    int b = int.Parse(valores[1]);
    int soma = a + b;
    if (soma % 2 == 0){
      if (escolhas[1].Equals("PAR")){
        Console.WriteLine(escolhas[0]);
      }
      else{
        Console.WriteLine(escolhas[2]);
      }
    }
    else{
      if (escolhas[1].Equals("IMPAR")){
        Console.WriteLine(escolhas[0]);
      }
      else{
        Console.WriteLine(escolhas[2]);
        }
      }
    }
  }
}
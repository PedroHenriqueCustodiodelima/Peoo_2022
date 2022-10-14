using System;
class Program{
  static void Main(string[] args){
  int soma = 0;
  int sair = 0;
  int maior = 1;
  int menor = 1;
  while (sair !=1){
    string[] vetor = Console.ReadLine().Split(' ');
    int a = int.Parse(vetor[0]);
    int b = int.Parse(vetor[1]);
    if (a <= 0 || b <= 0){
      sair = 1;
    }
    else{
      if (a > b){
        maior = a;
        menor = b;
      }
      else{
        maior = b;
        menor = a;
      }
      for (int c = menor; c <= maior; c++){
        soma = soma + c;
        Console.Write(c + " ");
      }
      Console.WriteLine("Sum=" + soma);
      soma = 0;
      }
    }
  }
}
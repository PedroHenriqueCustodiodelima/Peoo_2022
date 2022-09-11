using System;
class Program{
  static void Main(string[] args){
    int n, maior, menor, soma;
    soma = 0;
    n = int.Parse(Console.ReadLine());
    for (int i = 0; i < n; i++){
    string[] v = Console.ReadLine().Split(' ');
    int x = int.Parse(v[0]);
    int y = int.Parse(v[1]);
    if (x > y){
      maior = x;
      menor = y;
    }
    else{
      maior = y;
      menor = x;
    }
    for (int p = menor; p < maior; p++){
      if (p % 2 != 0 && p > menor){
        soma = soma + p;
      }
    }
    Console.WriteLine(soma);
    soma = 0;
   }
  }
}
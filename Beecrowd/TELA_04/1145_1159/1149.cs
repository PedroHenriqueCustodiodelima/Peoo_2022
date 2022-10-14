using System;
class Program{
  static void Main(string[] args){
    string[] valores = Console.ReadLine().Split(' ');
    int a = int.Parse(valores[0]);
    int i = 1;
    int n = int.Parse(valores[i]);
    while (n <= 0){
      i = i + 1;
      n = int.Parse(valores[i]);
    }
    int soma = 0;
    for (i = 0; i < n; i++){
      soma = soma + a + i;
    }
    Console.WriteLine(soma);
  }
}
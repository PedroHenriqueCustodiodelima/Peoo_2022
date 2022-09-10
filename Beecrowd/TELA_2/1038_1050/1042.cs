using System;
class Program{
  static void Main(string[] args){
    int maior, meio, menor;
    string[] valores = Console.ReadLine().Split(' ');
    int a = int.Parse(valores[0]);
    int b = int.Parse(valores[1]);
    int c = int.Parse(valores[2]);
    if (a < b && a < c){
      menor = a;
    if (b < c){
      meio = b;
      maior = c;
    }
    else{
      meio = c;
      maior = b;
    }
    }
    else if (b < c){
      menor = b;
    if (a < c){
      meio = a;
      maior = c;
    }
    else{
      meio = c;
      maior = a;
    }
    }
    else{
      menor = c;
    if (a < b){
      meio = a;
      maior = b;
    }
    else{
      meio = b;
      maior = a;
    }
    }
    Console.WriteLine(menor);
    Console.WriteLine(meio);
    Console.WriteLine(maior);
    Console.WriteLine();
    Console.WriteLine(a);
    Console.WriteLine(b);
    Console.WriteLine(c);
  }
}
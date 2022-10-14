using System;
class Program{
  static void Main(string[] args){
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int maior = 0;
    int menor = 0;
    if(a > b){
      maior = a;
      menor = b;
    }
    for (int c = menor + 1; c < maior; c++){
      if (c % 5 == 2 ||c % 5 ==3 ){
        Console.WriteLine(c);
      }
    }
  }
}
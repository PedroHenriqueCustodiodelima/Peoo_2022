using System;
class Program{
  static void Main(string[] args){
    int x = int.Parse(Console.ReadLine());
    int y = int.Parse(Console.ReadLine());        
    int menor = y;
    int maior = x;
    if (y > x){
      menor = x;
      maior = y;
    }
    int a = 0;
    for (int i = menor; i <= maior; i++){
      if (i % 13 != 0){
        a = a + i;
      }                    
    }
    Console.WriteLine(a);
  }
}
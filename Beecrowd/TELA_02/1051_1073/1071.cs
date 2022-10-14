using System;
class Program{
  static void Main(string[] args){
    int x, y, maior, menor, impar;
    x = int.Parse(Console.ReadLine());
    y = int.Parse(Console.ReadLine());
    impar = 0;
    if(x>y){
      maior = x;
      menor = y;
    }
    else{
      maior = y;
      menor = x;
    }
    for(int i = menor+1; i < maior; i++){
      if(i % 2 !=0){
        impar =impar + i;
      }
    }
    Console.WriteLine(impar);
  }
}
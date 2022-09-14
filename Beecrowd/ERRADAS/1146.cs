using System;
class Program{
  static void Main(string[] args){
  int a = 0;
  while(a < 1){
    int n = int.Parse(Console.ReadLine());
    if(n != 0){
      for (int i = 1; i <= n; i++){
        if (i == n){
          Console.WriteLine(i);
        }
        else{
          Console.Write($"{i} ");
        }
      }
    }
    if(n == 0){
      break;
      }  
    }
  }
}
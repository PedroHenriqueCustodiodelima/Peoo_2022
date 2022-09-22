using System;
class Program{
  static void Main(string[] args){
    while (true){
      try{   
        int N = int.Parse(Console.ReadLine());
        if (N == 0){
          Console.WriteLine("vai ter copa!");
        }
        else if (N > 0 && N <= 100){
          Console.WriteLine("vai ter duas!");
        }
        else{
           break;
        }
      }
      catch (Exception){
        break;
        throw;       
      }
    }
  }
}


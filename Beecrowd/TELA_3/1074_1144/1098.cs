using System;
class Program{
  static void Main(string[] args){
    double i, j;
    for (i = 0.0; i < 2.1; i+= 0.2){                
      for (j = 1.0; j <= 3; j++){
        double k = i + j;
        if(i == 0 || i > 1.8 || i > 0.9 && i < 1.1){
          Console.WriteLine($"I={i} J={k}");
        }
        else{
          Console.WriteLine($"I={i:0.0} J={k:0.0}");
        }
      }
    }
  }
}
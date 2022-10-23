using System;
class Program{
  static void Main(string[] args){
    string[] v = Console.ReadLine().Split(' ');
    int n = int.Parse(v[0]);              
    int m = int.Parse(v[1]);
    if(m - n >= 3){
      Console.WriteLine("Muito bem! Apresenta antes do Natal!");
    }
    else if(m - n < 0){
      Console.WriteLine("Eu odeio a professora!");
    }
    else if(m - n < 3){
      Console.WriteLine("Parece o trabalho do meu filho!");
      m += 2;
      if(m <= 24){
        Console.WriteLine("TCC Apresentado!");
      }
      else{
        Console.WriteLine("Fail! Entao eh nataaaaal!");
      }
    }
  }
}
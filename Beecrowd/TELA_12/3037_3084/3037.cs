using System;       
class Program{
  static void Main(string[] args) {
    int n = int.Parse(Console.ReadLine());
      int J, M;
      for (int i = 0; i < n; i++){
        J = 0;
        M = J;
      for (int j = 0; j < 3; j++){
        string[] x = Console.ReadLine().Split(' ');
        J += int.Parse(x[0]) * int.Parse(x[1]);
      }
      for (int k = 0; k < 3; k++){
        string[] x = Console.ReadLine().Split(' ');
        M += int.Parse(x[0]) * int.Parse(x[1]);
      }
      if (J > M){
        Console.WriteLine("JOAO");
      } 
      else{
        Console.WriteLine("MARIA");
      }
    }
  }
}
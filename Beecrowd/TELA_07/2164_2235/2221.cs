using System;
class Program{
  static void Main(string[] args){
    int n = int.Parse(Console.ReadLine());
    int golpe = 0;
    int golpe1 = 0;
    for (int i = 0; i < n; i++){     
      int bonus = int.Parse(Console.ReadLine());
      string[] v = Console.ReadLine().Split(' ');
      int ataque = int.Parse(v[0]);
      int defesa = int.Parse(v[1]);
      int level = int.Parse(v[2]);
      string[] v1 = Console.ReadLine().Split(' ');
      int ataque1 = int.Parse(v1[0]);
      int defesa1 = int.Parse(v1[1]);
      int level1 = int.Parse(v1[2]);
      if(level % 2 == 0){
        golpe = ((ataque + defesa)/2) + bonus;
      }
      else{
        golpe = ((ataque + defesa)/2);
      }
      if(level1 % 2 == 0){
         golpe1 = ((ataque1 + defesa1)/2) + bonus;
      }
      else{
        golpe1 = ((ataque1 + defesa1)/2);
      }
      if(golpe < golpe1){
        Console.WriteLine("Guarte");
      }
      else if(golpe > golpe1){
        Console.WriteLine("Dabriel");
      }
      else if(golpe1 == golpe){
        Console.WriteLine("Empate");
      }
    }       
  }
}
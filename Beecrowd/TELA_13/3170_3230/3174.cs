using System;
class Program{
  static void Main(string[] args) {
    int n = int.Parse(Console.ReadLine());
    int B = 0, A = 0, M = 0, D = 0;
    for (int i = 0; i < n; i++){
      string[] v = Console.ReadLine().Split(' ');
      string t = v[1];
      int horas = int.Parse(v[2]);  
      if (t == "bonecos"){
        B += horas;
      } 
      else if (t == "arquitetos"){
        A += horas;
      }
      else if (t == "musicos"){
        M += horas;
      }
      else{
        D += horas;
      }
    }      
    int brin = (B/8) + (A/4) + (M/6) + (D/12); 
    Console.WriteLine(brin);
  }
}
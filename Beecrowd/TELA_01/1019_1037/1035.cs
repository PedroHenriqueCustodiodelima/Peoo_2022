using System;
class Program{
static void Main(string[] args){
  string[] n1 = Console.ReadLine().Split(' ');
  int a = int.Parse(n1[0]);
  int b = int.Parse(n1[1]);
  int c = int.Parse(n1[2]);
  int d = int.Parse(n1[3]); 
  if (b > c && d > a && (c + d) > (a + b) && c > 0 && d > 0 && a % 2 == 0){
    Console.WriteLine("Valores aceitos");
  }
  else{
    Console.WriteLine("Valores nao aceitos");
    }
  }
}
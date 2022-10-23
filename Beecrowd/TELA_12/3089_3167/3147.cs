using System;
class Program{
  static void Main(string[] args){
    string[] v1 = Console.ReadLine().Split(' ');
    int h = int.Parse(v1[0]);              
    int e = int.Parse(v1[1]);
    int a = int.Parse(v1[2]);              
    int o = int.Parse(v1[3]);
    int w = int.Parse(v1[4]);              
    int x = int.Parse(v1[5]);
    if(h + e + a + x >= o + w){
      Console.WriteLine("Middle-earth is safe.");
    }
    else{
      Console.WriteLine("Sauron has returned.");
    }
  }
}
using System;        
class Program{
  static void Main(string[] args) {
    string[] v = Console.ReadLine().Split(' ');
    int h = int.Parse(v[0]);
    int z = int.Parse(v[1]);
    int l = int.Parse(v[2]);
    if ((z > h && h > l) || (z < h && h < l)){
      Console.WriteLine("huguinho");
    }
    else if ((h > z && z > l) || (h < z && z < l)){
      Console.WriteLine("zezinho");
    }
    else{
      Console.WriteLine("luisinho");
    }
  }
}
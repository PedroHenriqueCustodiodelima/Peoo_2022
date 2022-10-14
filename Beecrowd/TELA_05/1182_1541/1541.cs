using System;
using System.Linq;
class Program{
  static void Main(string[] args) {
    short[] v;
    while ((v = Console.ReadLine().Split(' ').Select(i => short.Parse(i)).ToArray()).Sum(i => i) != 0){
      Console.WriteLine((int)(10 * Math.Sqrt(v[0] * v[1]) / Math.Sqrt(v[2])));
    }
  }
}
using System;
using System.Linq;
class Program{
  static void Main(string[] args){
  string n = Console.ReadLine();
  string i = new string(n.Reverse().ToArray());
  Console.WriteLine(i);
  }
}
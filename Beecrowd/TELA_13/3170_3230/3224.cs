using System;
class Program{
  static void Main(string[] args) {
    string jon = Console.ReadLine();
    string doc = Console.ReadLine();
    if (jon.Length >= doc.Length){
      Console.WriteLine("go");
    }
    else{
      Console.WriteLine("no");
    }
  }
}
using System;
class Program{
  static void Main(string[] args) {
    string a = Console.ReadLine();
    string b = Console.ReadLine();
    if (string.Compare(a, b) <= 0){
      Console.WriteLine($"{a}\n{b}");
    }
    else{
      Console.WriteLine($"{b}\n{a}");
    }
  }
}
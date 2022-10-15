using System;        
class Program{
  static void Main(string[] args) {
    string v;
    while ((v = Console.ReadLine()) != null){
      Console.WriteLine((v.Length >= 10 ? "palavrao" : "palavrinha"));
    }
  }
}
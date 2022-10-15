using System;        
class Program{
  static void Main(string[] args) {
    string v;    
    while ((v = Console.ReadLine()) != null){
      int n = int.Parse(v);
      for (int i = 1; i <= n; i++){
        string a = Console.ReadLine();
        Console.WriteLine($"resposta {i}: {a}");
      }
    }
  }
}
using System; 
class Program{
  static void Main(string[] args) { 
    int v = int.Parse(Console.ReadLine());
    for (int i = 0; i < v; i++){
      int x = int.Parse(Console.ReadLine());
      if(x <= 8000)
        Console.WriteLine("Inseto!");
      else
        Console.WriteLine("Mais de 8000!");
    }
  }
}
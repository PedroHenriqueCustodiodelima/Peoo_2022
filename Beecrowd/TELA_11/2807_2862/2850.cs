using System; 
class Program{
  static void Main(string[] args) {
    string frase;
    while ((frase = Console.ReadLine()) != null){
      switch (frase){
        case "as duas":
          Console.WriteLine("caiu");
          break;
        case "direita":
          Console.WriteLine("frances");
          break;
        case "nenhuma":
          Console.WriteLine("portugues");
          break;
        case "esquerda":
          Console.WriteLine("ingles");
          break;
      }
    }
  }
}
using System; 
class Program{
  static void Main(string[] args) {
    string str;
    while (!string.IsNullOrEmpty(str = Console.ReadLine())){
      int graus = int.Parse(str);
      if (graus < 90) Console.WriteLine("Bom Dia!!");
      else if (graus < 180) Console.WriteLine("Boa Tarde!!");
      else if (graus < 270) Console.WriteLine("Boa Noite!!");
      else if (graus < 360) Console.WriteLine("De Madrugada!!");
      else Console.WriteLine("Bom Dia!!");
    }
  }
}
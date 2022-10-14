using System; 
class Program{
  static void Main(string[] args){
    int n = int.Parse(Console.ReadLine());
    string sequencia = "";
    while (n != 0){
      for (int i = 1; i < n; i++){
        sequencia = sequencia + i + " ";
      }
        sequencia = sequencia + n;
        Console.WriteLine(sequencia);
        sequencia = "";
        n = int.Parse(Console.ReadLine());
    }
  }
}
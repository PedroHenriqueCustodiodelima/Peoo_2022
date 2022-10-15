using System; 
class Program{
  static void Main(string[] args) {
    double n = double.Parse(Console.ReadLine().Trim());
    if (n == 0){
      Console.WriteLine("E");
    }
    else if (n <= 35){
      Console.WriteLine("D");
    }
    else if (n <= 60){
      Console.WriteLine("C");
    }
    else if (n <= 85){
      Console.WriteLine("B");
    }
    else if (n <= 100){
      Console.WriteLine("A");
    } 
  }
}
using System; 
class Program{
  static void Main(string[] args) {
    string str;
    while (!string.IsNullOrEmpty(str = Console.ReadLine())){
      int n = int.Parse(str);
       Console.WriteLine(n - 1);
    }
  }
}
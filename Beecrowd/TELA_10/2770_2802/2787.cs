using System; 
class Program{
  static void Main(string[] args) {
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    if(a % 2 != 0){
      if(b % 2 != 0){
        Console.WriteLine("1");
      }
      else{
        Console.WriteLine("0");
      }
    }
    else if(a % 2 == 0){
      if(b % 2 == 0){
        Console.WriteLine("1");
      }
      else{
        Console.WriteLine("0");
      }
    }
  }
}
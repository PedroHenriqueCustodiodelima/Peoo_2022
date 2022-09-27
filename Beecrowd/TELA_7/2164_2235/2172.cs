using System; 
class Program{
  static void Main(string[] args) {
    long mult, quan;
    while(true){
      string[] v1 = Console.ReadLine().Split(' ');
      mult = long.Parse(v1[0]);
      quan = long.Parse(v1[1]);
    
    if(mult == 0 && quan == 0){
      break;
    }
    Console.WriteLine(mult * quan);
    }
  }
}
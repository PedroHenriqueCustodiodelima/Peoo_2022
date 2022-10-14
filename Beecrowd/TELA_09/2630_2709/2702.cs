using System; 
class Program{
  static void Main(string[] args) {
    string[] v = Console.ReadLine().Split();
    int Ca = int.Parse(v[0]);
    int Ba = int.Parse(v[1]);
    int Pa = int.Parse(v[2]);
    string[] v1 = Console.ReadLine().Split();
    int Cr = int.Parse(v1[0]);
    int Br = int.Parse(v1[1]);
    int Pr = int.Parse(v1[2]);
    int calc = 0;
    if( Cr > Ca ){
      calc += Cr - Ca;
    }
    if( Br > Ba ){
      calc += Br - Ba;
    } 
    if( Pr > Pa ){
      calc += Pr - Pa;
    } 
    Console.WriteLine(calc);
  }
}
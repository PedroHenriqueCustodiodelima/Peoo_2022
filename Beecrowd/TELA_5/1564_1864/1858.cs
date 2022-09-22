using System; 
class Program{
  static void Main(string[] args) { 
    int menor = 21;
    int posMenor = 0;
    int n = int.Parse(Console.ReadLine());
    string[] v = Console.ReadLine().Split(' ');
    for (int i = 0; i < v.Length; i++) {        
      int t = int.Parse(v[i]);
      if (menor > t) {
        menor = t;
        posMenor = i + 1;
      } 
    }     
    Console.WriteLine(posMenor);
  }
}
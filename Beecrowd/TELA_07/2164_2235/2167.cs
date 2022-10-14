using System; 
class Program{
  static void Main(string[] args) {
    int n = int.Parse(Console.ReadLine());
    string[] v = Console.ReadLine().Split(' ');
    int[] r = new int[n];
    int queda = 0;
    int.TryParse(v[0], out r[0]);
    for (int i = 1; i < n; i++){
      int.TryParse(v[i], out r[i]);
      if (r[i] < r[i - 1] && queda == 0){
        queda = i + 1;
      }
    }
    Console.WriteLine(queda);
  }
}
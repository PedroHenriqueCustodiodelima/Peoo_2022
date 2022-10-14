using System; 
class Program{
  static void Main(string[] args) {
    int cont = 0;
    string[] v1 = Console.ReadLine().Split(' ');
    int x = int.Parse(v1[0]);
    int p = int.Parse(v1[1]);
    int r = x;
    while(cont < p){
      string a = Console.ReadLine();
      if(a[0] == 'f'){
        r = r + 1;
      }
      else{
        r = r - 1;
      }
      cont++;
    }
    Console.WriteLine($"{r}");
  }
}
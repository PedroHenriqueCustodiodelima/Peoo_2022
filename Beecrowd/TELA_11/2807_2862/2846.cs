using System; 
class Program{
  static int Fibonot(int n){
    int a = 0, b = 1, cnt = 0, ans = 4;
    while (cnt < n){
      for (int i = a + 1; i < b; i++){
        ans = i;
        if (++cnt == n)
          break;
        } 
        int temp = a;
        a = b;
        b = temp;
        b = a + b;
        }
      return ans;
    } 
    static void Main(string[] args) { 
      int n = int.Parse(Console.ReadLine());
      Console.WriteLine(Fibonot(n));
  }
}
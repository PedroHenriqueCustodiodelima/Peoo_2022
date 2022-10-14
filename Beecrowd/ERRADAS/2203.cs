using System; 
class Program{
  static void Main(string[] args) {
    int n = 2;
    for (int i = 0; i < n; i++){
      string[] v = Console.ReadLine().Split(' ');
      int xf = int.Parse(v[0]);
      int yf = int.Parse(v[1]);
      int xi = int.Parse(v[2]);
      int yi = int.Parse(v[3]);
      int vi = int.Parse(v[4]);
      int r1 = int.Parse(v[5]);
      int r2 = int.Parse(v[6]);
      double x = Math.Pow(xi - xf, 2.0) + Math.Pow(yi - yf, 2.0);
      double x1 = Math.Sqrt(x);
      double x2 = x1 + (vi * 1.50);
      int d2 = r1 + r2;
      if (x2 > d2){
        Console.WriteLine("N");
      }
    	else{
        Console.WriteLine("Y");
      }
    }
  }
}